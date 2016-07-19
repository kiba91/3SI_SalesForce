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
        public string GroupJson { get; set; }

        public Groups.GroupJsonRespone Grouplist;
        public ProfileModel() {

        }
        public ProfileModel(string accessToken)
        {
            var apiServices = new ApiService(accessToken);
            GroupJson = apiServices.GetUserGroup();
            // Convert json string to C# object 
            Grouplist = JsonConvert.DeserializeObject<Groups.GroupJsonRespone>(GroupJson);
        }
    }
}