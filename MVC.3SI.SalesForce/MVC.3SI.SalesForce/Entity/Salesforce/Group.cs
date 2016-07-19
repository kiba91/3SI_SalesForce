using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC._3SI.SalesForce.Entity.Salesforce
{
    public class Groups
    {
            public class Photo
            {
                public string largePhotoUrl { get; set; }
                public string mediumPhotoUrl { get; set; }
                public string smallPhotoUrl { get; set; }
                public string url { get; set; }
            }
            public class Photo2
            {
                public string largePhotoUrl { get; set; }
                public string mediumPhotoUrl { get; set; }
                public string smallPhotoUrl { get; set; }
            }
            public class Owner
            {
                public string name { get; set; }
                public Photo photo { get; set; }
            }
            public class Group
            {
                public BannerPhoto bannerPhoto { get; set; }
                public string description { get; set; }
                public string lastFeedElementPostDate { get; set; }
                public int memberCount { get; set; }
                public string myRole { get; set; }
                public string name { get; set; }
                public Owner owner { get; set; }
                public Photo2 photo { get; set; }
            }
            public class GroupJsonRespone
            {
                public List<Group> groups { get; set; }
            }
        }
}