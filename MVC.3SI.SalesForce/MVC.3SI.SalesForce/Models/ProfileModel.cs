using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC._3SI.SalesForce.Infrastructure.Salesforce;
using Newtonsoft.Json;
using MVC._3SI.SalesForce.Entity.Salesforce;
namespace MVC._3SI.SalesForce.Models
{


    //=======================================================================
    public class ProfileModel
    {
        public string Text { get; set; }

        public Groups.GroupRoot Jobject;
        public ProfileModel() {

        }
        public ProfileModel(string accessToken)
        {
            var apiServices = new ApiService(accessToken);
            Text = apiServices.GetUserGroup();

            // Convert json string to C# object 
            Jobject = JsonConvert.DeserializeObject<Groups.GroupRoot>(Text);

        }
    }
}