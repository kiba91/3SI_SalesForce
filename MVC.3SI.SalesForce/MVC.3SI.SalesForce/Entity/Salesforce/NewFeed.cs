using System.Collections.Generic;

namespace MVC._3SI.SalesForce.Entity.Salesforce
{
    public class NewFeed
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

        public class CommentsPage
        {
            public List<object> items { get; set; }
            public List<FeedComment.CommentList> commentList { get; set; }
            public int total { get; set; }
        }

        public class Comments
        {
            public CommentsPage page { get; set; }
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

        public class ParentPhoto
        {
            public string mediumPhotoUrl { get; set; }
        }

        public class Parent
        {
            public string id { get; set; }
            public string name { get; set; }
            public ParentPhoto photo { get; set; }
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

        public class FeedList
        {
            public List<Element> elements { get; set; }
        }
    }

    public class FeedComment
    {
        public class Body
        {
            public string text { get; set; }
        }

        public class ParentPhoto
        {
            public string smallPhotoUrl { get; set; }
        }

        public class User2
        {
            public string name { get; set; }
            public ParentPhoto photo { get; set; }
        }

        public class CommentList
        {
            public Body body { get; set; }
            public string createdDate { get; set; }
            public User2 user { get; set; }
        }
    }
}