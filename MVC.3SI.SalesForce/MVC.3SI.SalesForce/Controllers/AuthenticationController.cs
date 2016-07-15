using System.Web;
using System.Web.Mvc;
using MVC._3SI.SalesForce.Infrastructure.Salesforce;
using MVC._3SI.SalesForce.Infrastructure;
using System.Data;
using System;

namespace MVC._3SI.SalesForce.Controllers
{
    public class AuthenticationController : Controller
    {
        public void Index(string code)
        {
            if (!string.IsNullOrEmpty(code))
            {
                var accessTokenRequest = new AccessTokenService();
                var tokenData = accessTokenRequest.GetAccessToken(code);
                if (!string.IsNullOrEmpty(tokenData.access_token))
                {
                    //access token is available
                    Session[Constants.AccessTokenSession] = tokenData.access_token;
                    //refresh access token
                    var refreshTokenCookie = new HttpCookie(Constants.RefreshAccessTokenSession, tokenData.refresh_token);
                    refreshTokenCookie.Expires = DateTime.Now.AddYears(1);
                    Response.SetCookie(refreshTokenCookie);
                    //Response.Redirect("/chatter");
                    Response.Write("token: " + tokenData.access_token);
                    Response.Write("<br>refresh token: " + tokenData.refresh_token);
                }
                else
                {
                    var refreshTokenCookie = Response.Cookies[Constants.RefreshAccessTokenSession];
                    if (!string.IsNullOrEmpty(refreshTokenCookie.Value))
                    {
                        //the author code is expired, get new access token by refresh token
                        var refreshTokenData = accessTokenRequest.RefreshAccessToken(refreshTokenCookie.Value);
                        if (!string.IsNullOrEmpty(refreshTokenData.access_token)) {
                            Session[Constants.AccessTokenSession] = refreshTokenData.access_token;

                            Response.Write("new access token: " + refreshTokenData.access_token);
                        }
                    }
                }

                Response.Write("<br><a href=\"/chatter\">Go to Chatter page</a>");

            }
            else
            {
                Response.Write("Sorry, we can not get your access token. Please try again.");
            }

        }
    }
}