using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVC._3SI.SalesForce.Controllers;
using MVC._3SI.SalesForce.Models;
using MVC._3SI.SalesForce.Infrastructure;
using System.Web.Mvc;
using System.Web;

namespace MVC._3SI.SalesForce.Services
{
    public class ProfileServiceController : ApiController
    {
        // GET api/profileservice
        public string Get()
        {
            //return profile.GetProfile();
            //profile = Getprofile.GetProfile();
            //var getProfile = new ProfileModel(Convert.ToString(Constants.RefreshAccessTokenSession));
         //   return getProfile.GroupJson;
            return "value";
        }


        // GET api/chatterservice/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/chatterservice
        public void Post([FromBody]string value)
        {
        }

        // PUT api/chatterservice/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/chatterservice/5
        public void Delete(int id)
        {
        }
    }
}