using MVC._3SI.SalesForce.Entity.Salesforce;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;

namespace MVC._3SI.SalesForce.Infrastructure.Salesforce
{
    public class AccessTokenService
    {
        private string _loginRemoteUrl { get; set; }
        private string _clientId { get; set; }
        private string _clientSecret { get; set; }
        private string _callbackUrl { get; set; }

        public AccessTokenService()
        {
            _loginRemoteUrl = Helper.GetAppSettingValue("SF_LoginRemoteUrl");
            _clientId = Helper.GetAppSettingValue("SF_ClientKey");
            _clientSecret = Helper.GetAppSettingValue("SF_ClientSecret");
            _callbackUrl = Helper.GetAppSettingValue("SF_CallbackUrl");
        }

        public string AuthorizationEndpoint
        {
            get
            {
                return string.Format("{0}/services/oauth2/authorize?response_type=code&client_id={1}&redirect_uri={2}&scope=id%20api%20refresh_token%20chatter_api",
                                        _loginRemoteUrl, _clientId, _callbackUrl);
            }
            private set { }
        }

        public RefreshAuthorizationToken GetAccessToken(string code)
        {
            var url = string.Format("{0}/services/oauth2/token?grant_type=authorization_code&client_id={1}&client_secret={2}&redirect_uri={3}&code={4}"
                , _loginRemoteUrl,_clientId,_clientSecret,Helper.UrlEncode(_callbackUrl),Helper.UrlEncode(code));
            var apiRequest = new ApiWebRequest(url, Constants.Method.Post);
            var response = apiRequest.DoRequest();
            return JsonConvert.DeserializeObject<RefreshAuthorizationToken>(response);
        }

        public AuthorizationToken RefreshAccessToken(string refreshToken) {
            var url = string.Format("{0}/services/oauth2/token?grant_type=refresh_token&client_id={1}&client_secret={2}&refresh_token={3}"
                , _loginRemoteUrl, _clientId, _clientSecret, Helper.UrlEncode(refreshToken));
            var apiRequest = new ApiWebRequest(url, Constants.Method.Post);
            var response = apiRequest.DoRequest();

            return JsonConvert.DeserializeObject<AuthorizationToken>(response);
        }
    }
}