using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC._3SI.SalesForce.Infrastructure.Salesforce;
namespace MVC._3SI.SalesForce.Models
{
    public class ChatterModel : GenericModel
    {
        public string Text { get; set; }
        public ChatterModel() {

        }
        public ChatterModel(string accessToken) {
            var apiServices = new ApiService(accessToken);
            Text = apiServices.GetUserFeeds();
        }
    }
}