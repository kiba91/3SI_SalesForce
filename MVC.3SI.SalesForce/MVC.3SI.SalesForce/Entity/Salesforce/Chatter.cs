using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC._3SI.SalesForce.Infrastructure.Salesforce;
using Newtonsoft.Json;

namespace MVC._3SI.SalesForce.Entity.Salesforce
{
    public class Chatter
    { }
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

    public class Actor
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
        public Motif motif { get; set; }
        public MySubscription mySubscription { get; set; }
        public string name { get; set; }
        public Photo photo { get; set; }
        public object reputation { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public string userType { get; set; }
    }

    public class Body
    {
        public bool? isRichText { get; set; }
        public List<object> messageSegments { get; set; }
        public string text { get; set; }
    }

    public class AssociatedActions
    {
        public List<object> platformActionGroups { get; set; }
    }

    public class Bookmarks
    {
        public bool isBookmarkedByCurrentUser { get; set; }
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

    public class MessageSegment
    {
        public string text { get; set; }
        public string type { get; set; }
        public Motif2 motif { get; set; }
        public Reference reference { get; set; }
    }

    public class LikesMessage
    {
        public object isRichText { get; set; }
        public List<MessageSegment> messageSegments { get; set; }
        public string text { get; set; }
    }

    public class MyLike
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Page
    {
        public int currentPageToken { get; set; }
        public string currentPageUrl { get; set; }
        public List<object> items { get; set; }
        public object nextPageToken { get; set; }
        public object nextPageUrl { get; set; }
        public object previousPageToken { get; set; }
        public object previousPageUrl { get; set; }
        public int total { get; set; }
    }

    public class ChatterLikes
    {
        public bool isLikedByCurrentUser { get; set; }
        public LikesMessage likesMessage { get; set; }
        public MyLike myLike { get; set; }
        public Page page { get; set; }
    }

    public class Page2
    {
        public object currentPageToken { get; set; }
        public string currentPageUrl { get; set; }
        public List<object> items { get; set; }
        public object nextPageToken { get; set; }
        public object nextPageUrl { get; set; }
        public int total { get; set; }
    }

    public class Comments
    {
        public Page2 page { get; set; }
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

    public class Interactions
    {
        public int count { get; set; }
    }

    public class Link
    {
        public string url { get; set; }
        public string urlName { get; set; }
    }

    public class Mute
    {
        public bool isMutedByMe { get; set; }
    }

    public class Status
    {
        public string feedEntityStatus { get; set; }
        public bool isApprovableByMe { get; set; }
    }

    public class Topics
    {
        public bool canAssignTopics { get; set; }
        public List<object> items { get; set; }
    }

    public class QuestionAndAnswers
    {
        public object bestAnswer { get; set; }
        public object bestAnswerSelectedBy { get; set; }
        public bool canCurrentUserSelectOrRemoveBestAnswer { get; set; }
        public object escalatedCase { get; set; }
        public string questionTitle { get; set; }
    }

    public class Change
    {
        public string fieldName { get; set; }
        public string newValue { get; set; }
        public string oldValue { get; set; }
    }

    public class TrackedChanges
    {
        public List<Change> changes { get; set; }
    }

    public class Capabilities
    {
        public AssociatedActions associatedActions { get; set; }
        public Bookmarks bookmarks { get; set; }
        public ChatterLikes chatterLikes { get; set; }
        public Comments comments { get; set; }
        public Edit edit { get; set; }
        public Interactions interactions { get; set; }
        public Link link { get; set; }
        public Mute mute { get; set; }
        public Status status { get; set; }
        public Topics topics { get; set; }
        public QuestionAndAnswers questionAndAnswers { get; set; }
        public TrackedChanges trackedChanges { get; set; }
    }

    public class Motif3
    {
        public string color { get; set; }
        public string largeIconUrl { get; set; }
        public string mediumIconUrl { get; set; }
        public string smallIconUrl { get; set; }
        public object svgIconUrl { get; set; }
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
        public object url { get; set; }
        public string valueType { get; set; }
    }

    public class MessageSegment2
    {
        public Motif3 motif { get; set; }
        public Reference2 reference { get; set; }
        public string text { get; set; }
        public string type { get; set; }
        public List<Segment> segments { get; set; }
    }

    public class Header
    {
        public object isRichText { get; set; }
        public List<MessageSegment2> messageSegments { get; set; }
        public string text { get; set; }
    }

    public class OriginalFeedItem
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Motif4
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

    public class OriginalFeedItemActor
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
        public Motif4 motif { get; set; }
        public object mySubscription { get; set; }
        public string name { get; set; }
        public Photo2 photo { get; set; }
        public object reputation { get; set; }
        public object title { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public string userType { get; set; }
    }

    public class Motif5
    {
        public string color { get; set; }
        public string largeIconUrl { get; set; }
        public string mediumIconUrl { get; set; }
        public string smallIconUrl { get; set; }
        public object svgIconUrl { get; set; }
    }

    public class MySubscription2
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Photo3
    {
        public string fullEmailPhotoUrl { get; set; }
        public string largePhotoUrl { get; set; }
        public string mediumPhotoUrl { get; set; }
        public string photoVersionId { get; set; }
        public string smallPhotoUrl { get; set; }
        public string standardEmailPhotoUrl { get; set; }
        public string url { get; set; }
    }

    public class BannerPhoto
    {
        public string bannerPhotoUrl { get; set; }
        public object bannerPhotoVersionId { get; set; }
        public string url { get; set; }
    }

    public class Motif6
    {
        public string color { get; set; }
        public string largeIconUrl { get; set; }
        public string mediumIconUrl { get; set; }
        public string smallIconUrl { get; set; }
        public object svgIconUrl { get; set; }
    }

    public class MySubscription3
    {
        public string id { get; set; }
        public string url { get; set; }
    }

    public class Photo4
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
        public Motif6 motif { get; set; }
        public MySubscription3 mySubscription { get; set; }
        public string name { get; set; }
        public Photo4 photo { get; set; }
        public object reputation { get; set; }
        public object title { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public string userType { get; set; }
    }

    public class Parent
    {
        public string additionalLabel { get; set; }
        public string communityNickname { get; set; }
        public string companyName { get; set; }
        public string displayName { get; set; }
        public string firstName { get; set; }
        public string id { get; set; }
        public bool isActive { get; set; }
        public bool isInThisCommunity { get; set; }
        public string lastName { get; set; }
        public Motif5 motif { get; set; }
        public MySubscription2 mySubscription { get; set; }
        public string name { get; set; }
        public Photo3 photo { get; set; }
        public object reputation { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public string userType { get; set; }
        public object announcement { get; set; }
        public BannerPhoto bannerPhoto { get; set; }
        public bool? canHaveChatterGuests { get; set; }
        public object community { get; set; }
        public string description { get; set; }
        public string emailToChatterAddress { get; set; }
        public bool? isArchived { get; set; }
        public bool? isAutoArchiveDisabled { get; set; }
        public bool? isBroadcast { get; set; }
        public string lastFeedElementPostDate { get; set; }
        public int? memberCount { get; set; }
        public string myRole { get; set; }
        public Owner owner { get; set; }
        public string visibility { get; set; }
    }

    public class Element
    {
        public Actor actor { get; set; }
        public Body body { get; set; }
        public bool canShare { get; set; }
        public Capabilities capabilities { get; set; }
        public object clientInfo { get; set; }
        public string createdDate { get; set; }
        public bool @event { get; set; }
        public string feedElementType { get; set; }
        public Header header { get; set; }
        public string id { get; set; }
        public bool isDeleteRestricted { get; set; }
        public string modifiedDate { get; set; }
        public OriginalFeedItem originalFeedItem { get; set; }
        public OriginalFeedItemActor originalFeedItemActor { get; set; }
        public Parent parent { get; set; }
        public string photoUrl { get; set; }
        public string relativeCreatedDate { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public string visibility { get; set; }
    }

    public class RootObject
    {
        public object currentPageToken { get; set; }
        public string currentPageUrl { get; set; }
        public List<Element> elements { get; set; }
        public object isModifiedToken { get; set; }
        public object isModifiedUrl { get; set; }
        public object nextPageToken { get; set; }
        public object nextPageUrl { get; set; }
        public string updatesToken { get; set; }
        public string updatesUrl { get; set; }
    }
}