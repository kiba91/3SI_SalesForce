using MVC._3SI.SalesForce.Entity.Salesforce;
using MVC._3SI.SalesForce.Infrastructure.Salesforce;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC._3SI.SalesForce.Models
{
    //=======================================================================
    public class ProfileModel
    {
        public Profile profileInfo;
        public NewFeed.FeedList feedProfile;
        public List<FeedComment.CommentList> commentList = new List<FeedComment.CommentList>();

        public ProfileModel()
        {
        }

        public ProfileModel(string accessToken)
        {
            //Request service
            var apiServices = new ApiService(accessToken);
            var profileJson = apiServices.GetUserProfile();
            var feedProfileJson = apiServices.GetUserFeeds();
            // Convert json string to C# object
            profileInfo = JsonConvert.DeserializeObject<Profile>(profileJson);
            feedProfile = JsonConvert.DeserializeObject<NewFeed.FeedList>(HttpUtility.HtmlDecode(feedProfileJson));
            foreach (var feed in feedProfile.elements)
            {
                //Get all feed
                feed.orderDate = feed.createdDate;
                if (feed.capabilities.comments.page.total > 0)
                {
                    feed.capabilities.comments.page.commentList = new List<FeedComment.CommentList>();
                    foreach (var comment in feed.capabilities.comments.page.items)
                    {
                        var a = JsonConvert.DeserializeObject<FeedComment.CommentList>(comment.ToString());
                        feed.capabilities.comments.page.commentList.Add(a);
                    }
                    // Set date of newest Action to orderDate
                    feed.orderDate = feed.capabilities.comments.page.commentList[feed.capabilities.comments.page.total - 1].createdDate;
                }
            }
            //Oder chatter by newest action
            feedProfile.elements = feedProfile.elements.OrderByDescending(i => i.orderDate).ToList();
        }
    }
}