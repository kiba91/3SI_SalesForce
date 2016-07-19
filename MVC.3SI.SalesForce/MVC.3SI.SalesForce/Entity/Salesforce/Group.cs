using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC._3SI.SalesForce.Entity.Salesforce
{
    public class Groups
    {
        public class BannerPhoto
        {
            public string bannerPhotoUrl { get; set; }
            public object bannerPhotoVersionId { get; set; }
            public string url { get; set; }
        }

        public class Information
        {
            public object text { get; set; }
            public object title { get; set; }
        }

        public class Motif
        {
            public string color { get; set; }
            public string largeIconUrl { get; set; }
            public string mediumIconUrl { get; set; }
            public string smallIconUrl { get; set; }
            public object svgIconUrl { get; set; }
        }

        public class MySubscription
        {
            public string id { get; set; }
            public string url { get; set; }
        }

        public class Motif2
        {
            public string color { get; set; }
            public string largeIconUrl { get; set; }
            public string mediumIconUrl { get; set; }
            public string smallIconUrl { get; set; }
            public object svgIconUrl { get; set; }
        }

        public class Photo
        {
            public string fullEmailPhotoUrl { get; set; }
            public string largePhotoUrl { get; set; }
            public string mediumPhotoUrl { get; set; }
            public object photoVersionId { get; set; }
            public string smallPhotoUrl { get; set; }
            public string standardEmailPhotoUrl { get; set; }
            public string url { get; set; }
        }

        public class Owner
        {
            public object additionalLabel { get; set; }
            public string communityNickname { get; set; }
            public string companyName { get; set; }
            public string displayName { get; set; }
            public string firstName { get; set; }
            public string id { get; set; }
            public bool isActive { get; set; }
            public bool isInThisCommunity { get; set; }
            public string lastName { get; set; }
            public Motif2 motif { get; set; }
            public object mySubscription { get; set; }
            public string name { get; set; }
            public Photo photo { get; set; }
            public object reputation { get; set; }
            public object title { get; set; }
            public string type { get; set; }
            public string url { get; set; }
            public string userType { get; set; }
        }

        public class Photo2
        {
            public string fullEmailPhotoUrl { get; set; }
            public string largePhotoUrl { get; set; }
            public string mediumPhotoUrl { get; set; }
            public string photoVersionId { get; set; }
            public string smallPhotoUrl { get; set; }
            public string standardEmailPhotoUrl { get; set; }
            public string url { get; set; }
        }

        public class Group
        {
            public string additionalLabel { get; set; }
            public object announcement { get; set; }
            public BannerPhoto bannerPhoto { get; set; }
            public bool canHaveChatterGuests { get; set; }
            public object community { get; set; }
            public string description { get; set; }
            public string emailToChatterAddress { get; set; }
            public int fileCount { get; set; }
            public string id { get; set; }
            public Information information { get; set; }
            public bool isArchived { get; set; }
            public bool isAutoArchiveDisabled { get; set; }
            public bool isBroadcast { get; set; }
            public string lastFeedElementPostDate { get; set; }
            public int memberCount { get; set; }
            public Motif motif { get; set; }
            public string myRole { get; set; }
            public MySubscription mySubscription { get; set; }
            public string name { get; set; }
            public Owner owner { get; set; }
            public object pendingRequests { get; set; }
            public Photo2 photo { get; set; }
            public string type { get; set; }
            public string url { get; set; }
            public string visibility { get; set; }
        }

        public class GroupRoot
        {
            public List<Group> groups { get; set; }
        }
    }
    
}