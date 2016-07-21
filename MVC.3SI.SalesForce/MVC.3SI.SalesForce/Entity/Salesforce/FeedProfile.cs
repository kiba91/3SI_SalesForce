using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC._3SI.SalesForce.Entity.Salesforce
{
    public class FeedProfile
    {
        public class Photo
        {
            public string mediumPhotoUrl { get; set; }
        }

        public class Actor
        {
            public string name { get; set; }
            public Photo photo { get; set; }
        }

        public class Body
        {
            public bool? isRichText { get; set; }
            public List<object> messageSegments { get; set; }
            public string text { get; set; }
        }

        public class MessageSegment
        {
            public string text { get; set; }
            public string type { get; set; }
        }

        public class LikesMessage
        {
            public List<MessageSegment> messageSegments { get; set; }
            public string text { get; set; }
        }

        public class MyLike
        {
            public string id { get; set; }
            public string url { get; set; }
        }
        public class ChatterLikes
        {
            public LikesMessage likesMessage { get; set; }
            public MyLike myLike { get; set; }
        }

        public class Page2
        {
            public List<object> items { get; set; }
            public List<feedComment.RootObject> commentList { get; set; }
            public int total { get; set; }
        }

        public class Comments
        {
            public Page2 page { get; set; }
        }

        public class Mute
        {
            public bool isMutedByMe { get; set; }
        }

        public class Capabilities
        {
            public ChatterLikes chatterLikes { get; set; }
            public Comments comments { get; set; }
        }

        public class Reference2
        {
            public string id { get; set; }
            public string url { get; set; }
        }

        public class Segment
        {
            public string text { get; set; }
            public string type { get; set; }
            public string valueType { get; set; }
        }

        public class MessageSegment2
        {
            public string text { get; set; }
            public string type { get; set; }
            public Reference2 reference { get; set; }
            public List<Segment> segments { get; set; }
        }

        public class Header
        {
            public List<MessageSegment2> messageSegments { get; set; }
            public string text { get; set; }
        }
        public class Photo2
        {
            public string mediumPhotoUrl { get; set; }
        }

        public class Parent
        {
            public string id { get; set; }
            public string name { get; set; }
            public Photo2 photo { get; set; }
        }

        public class Element
        {
            public string orderDate { get; set; }
            public Actor actor { get; set; }
            public Body body { get; set; }
            public bool canShare { get; set; }
            public Capabilities capabilities { get; set; }
            public string createdDate { get; set; }
            public Header header { get; set; }
            public string modifiedDate { get; set; }
            public Parent parent { get; set; }
        }

        public class feedList
        {
            public List<Element> elements { get; set; }
        }
    }

    public class feedComment{
        public class MessageSegment
        {
            public string text { get; set; }
            public string type { get; set; }
        }

        public class Body
        {
            public bool isRichText { get; set; }
            public List<MessageSegment> messageSegments { get; set; }
            public string text { get; set; }
        }

        public class Edit
        {
            public bool isEditRestricted { get; set; }
            public string isEditableByMeUrl { get; set; }
            public object lastEditedBy { get; set; }
            public object lastEditedDate { get; set; }
            public int latestRevision { get; set; }
            public object relativeLastEditedDate { get; set; }
        }

        public class Capabilities
        {
            public Edit edit { get; set; }
        }

        public class FeedElement
        {
            public string id { get; set; }
            public string url { get; set; }
        }

        public class LikedItem
        {
            public string id { get; set; }
            public string url { get; set; }
        }

        public class Motif
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

        public class User
        {
            public object additionalLabel { get; set; }
            public string communityNickname { get; set; }
            public object companyName { get; set; }
            public string displayName { get; set; }
            public string firstName { get; set; }
            public string id { get; set; }
            public bool isActive { get; set; }
            public bool isInThisCommunity { get; set; }
            public string lastName { get; set; }
            public Motif motif { get; set; }
            public object mySubscription { get; set; }
            public string name { get; set; }
            public Photo photo { get; set; }
            public object reputation { get; set; }
            public object title { get; set; }
            public string type { get; set; }
            public string url { get; set; }
            public string userType { get; set; }
        }

        public class Item
        {
            public string id { get; set; }
            public LikedItem likedItem { get; set; }
            public string url { get; set; }
            public User user { get; set; }
        }

        public class Likes
        {
            public int? currentPageToken { get; set; }
            public string currentPageUrl { get; set; }
            public List<Item> items { get; set; }
            public object nextPageToken { get; set; }
            public object nextPageUrl { get; set; }
            public object previousPageToken { get; set; }
            public object previousPageUrl { get; set; }
            public int total { get; set; }
        }

        public class Motif2
        {
            public string color { get; set; }
            public string largeIconUrl { get; set; }
            public string mediumIconUrl { get; set; }
            public string smallIconUrl { get; set; }
            public object svgIconUrl { get; set; }
        }

        public class Reference
        {
            public string id { get; set; }
            public string url { get; set; }
        }

        public class MessageSegment2
        {
            public Motif2 motif { get; set; }
            public Reference reference { get; set; }
            public string text { get; set; }
            public string type { get; set; }
        }

        public class LikesMessage
        {
            public object isRichText { get; set; }
            public List<MessageSegment2> messageSegments { get; set; }
            public string text { get; set; }
        }

        public class Parent
        {
            public string id { get; set; }
            public string url { get; set; }
        }

        public class Motif3
        {
            public string color { get; set; }
            public string largeIconUrl { get; set; }
            public string mediumIconUrl { get; set; }
            public string smallIconUrl { get; set; }
            public object svgIconUrl { get; set; }
        }

        public class Photo2
        {
            public string fullEmailPhotoUrl { get; set; }
            public string largePhotoUrl { get; set; }
            public string mediumPhotoUrl { get; set; }
            public object photoVersionId { get; set; }
            public string smallPhotoUrl { get; set; }
            public string standardEmailPhotoUrl { get; set; }
            public string url { get; set; }
        }

        public class User2
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
            public Motif3 motif { get; set; }
            public object mySubscription { get; set; }
            public string name { get; set; }
            public Photo2 photo { get; set; }
            public object reputation { get; set; }
            public string title { get; set; }
            public string type { get; set; }
            public string url { get; set; }
            public string userType { get; set; }
        }

        public class RootObject
        {
            public Body body { get; set; }
            public Capabilities capabilities { get; set; }
            public object clientInfo { get; set; }
            public string createdDate { get; set; }
            public FeedElement feedElement { get; set; }
            public string id { get; set; }
            public bool isDeleteRestricted { get; set; }
            public Likes likes { get; set; }
            public LikesMessage likesMessage { get; set; }
            public object moderationFlags { get; set; }
            public object myLike { get; set; }
            public Parent parent { get; set; }
            public string relativeCreatedDate { get; set; }
            public string type { get; set; }
            public string url { get; set; }
            public User2 user { get; set; }
        }
    }
}