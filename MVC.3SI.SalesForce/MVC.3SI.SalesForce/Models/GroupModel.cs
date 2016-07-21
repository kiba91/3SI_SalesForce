using MVC._3SI.SalesForce.Entity.Salesforce;
using MVC._3SI.SalesForce.Infrastructure.Salesforce;
using Newtonsoft.Json;
using System.Web;

namespace MVC._3SI.SalesForce.Models
{
    //=======================================================================
    public class GroupModel
    {
        public Groups.GroupList Grouplist;

        public GroupModel()
        {
        }

        public GroupModel(string accessToken)
        {
            var apiServices = new ApiService(accessToken);
            var groupJson = apiServices.GetUserGroup();
            // Convert json string to C# object
            Grouplist = JsonConvert.DeserializeObject<Groups.GroupList>(HttpUtility.HtmlDecode(groupJson));
        }
    }
}