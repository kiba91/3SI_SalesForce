using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC._3SI.SalesForce.Infrastructure.Salesforce;
using Newtonsoft.Json;
using MVC._3SI.SalesForce.Entity.Salesforce;

namespace MVC._3SI.SalesForce.Models
{
    public class HeaderLogin : GenericModel
    {
        public RootObject Jobject;
        public string Text { get; set; }
        public HeaderLogin()
        {

        }
        public HeaderLogin(string accessToken)
        {
            var apiServices = new ApiService(accessToken);
            Text = apiServices.GetUserFeeds();
            Jobject = JsonConvert.DeserializeObject<RootObject>(Text);
        }
    }

}