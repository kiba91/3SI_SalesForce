using System.Collections.Generic;

namespace MVC._3SI.SalesForce.Infrastructure.Salesforce
{
    public class ApiService
    {
        public string AccessToken { get; set; }
        public string BaseUrl { get; set; }
        
        public ApiService(string accessToken) {
            AccessToken = accessToken;
            BaseUrl = Helper.GetAppSettingValue("SF_BaseUrl");
        }

        public string GetUserFeeds() {
            var request = new ApiWebRequest(string.Concat(BaseUrl, "/chatter/feeds/news/me/feed-elements"));
            request.HeaderSettings = new List<KeyValuePair<string, string>> {
                new KeyValuePair<string, string>("Authorization","Bearer " + AccessToken)
            };
            return request.DoRequest();
        }

        //Request to get User profile
        public string GetUserProfile()
        {
            var request = new ApiWebRequest(string.Concat(BaseUrl, "/chatter/users/me"));
            request.HeaderSettings = new List<KeyValuePair<string, string>> {
                new KeyValuePair<string, string>("Authorization","Bearer " + AccessToken)
            };
            return request.DoRequest();
        }

        //Request to get User group
        public string GetUserGroup()
        {
            var request = new ApiWebRequest(string.Concat(BaseUrl, "/chatter/groups"));
            request.HeaderSettings = new List<KeyValuePair<string, string>> {
                new KeyValuePair<string, string>("Authorization","Bearer " + AccessToken)
            };
            return request.DoRequest();
        }

    }

}