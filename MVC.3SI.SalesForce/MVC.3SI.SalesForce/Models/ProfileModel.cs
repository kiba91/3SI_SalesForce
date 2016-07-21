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
        public Profile profileInfo;
        public FeedProfile.feedList feedProfile;
        public List<feedComment.RootObject> commentList = new List<feedComment.RootObject>();

        public ProfileModel() {
        }

        public ProfileModel(string accessToken)
        {
            //Request service
            var apiServices = new ApiService(accessToken);
            var profileJson = apiServices.GetUserProfile();
            var feedProfileJson = apiServices.GetUserFeeds();
            // Convert json string to C# object 
            profileInfo = JsonConvert.DeserializeObject<Profile>(profileJson);
            feedProfile = JsonConvert.DeserializeObject<FeedProfile.feedList>(feedProfileJson);
            foreach (var feed in feedProfile.elements ){
                feed.orderDate = feed.createdDate;
                if (feed.capabilities.comments.page.total > 0)
                {
                    feed.capabilities.comments.page.commentList = new List<feedComment.RootObject>();
                    foreach (var comment in feed.capabilities.comments.page.items)
                    {
                        var a = JsonConvert.DeserializeObject<feedComment.RootObject>(comment.ToString());                        
                        feed.capabilities.comments.page.commentList.Add(a);
                    }
                    feed.orderDate = feed.capabilities.comments.page.commentList[feed.capabilities.comments.page.total - 1].createdDate;
                }
            }
            feedProfile.elements = feedProfile.elements.OrderByDescending(i => i.orderDate).ToList();
        }
    }
}