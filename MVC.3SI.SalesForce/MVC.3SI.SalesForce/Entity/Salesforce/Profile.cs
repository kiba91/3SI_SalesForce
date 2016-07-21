using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC._3SI.SalesForce.Entity.Salesforce
{
    public class ProfileRootObject
    {
        public string displayName { get; set; }

    }

    public class Address
    {
        public string city { get; set; }
        public string country { get; set; }
        public string formattedAddress { get; set; }
        public string state { get; set; }
        public string street { get; set; }
        public string zip { get; set; }
    }
    public class ChatterActivity
    {
        public int commentCount { get; set; }
        public int commentReceivedCount { get; set; }
        public int likeReceivedCount { get; set; }
        public int postCount { get; set; }
    }
    public class ChatterInfluence
    {
        public string percentile { get; set; }
        public int rank { get; set; }
    }
    public class FollowingCounts
    {
        public int people { get; set; }
        public int records { get; set; }
        public int total { get; set; }
    }
    public class PhoneNumber
    {
        public string phoneNumber { get; set; }
        public string phoneType { get; set; }
    }
    public class Photo
    {
        public string largePhotoUrl { get; set; }
        public string mediumPhotoUrl { get; set; }
        public string smallPhotoUrl { get; set; }
    }
    public class Profile
    {
        public string aboutMe { get; set; }
        public Address address { get; set; }
        public ChatterActivity chatterActivity { get; set; }
        public ChatterInfluence chatterInfluence { get; set; }
        public string communityNickname { get; set; }
        public string companyName { get; set; }
        public string displayName { get; set; }
        public string email { get; set; }
        public string firstName { get; set; }
        public int followersCount { get; set; }
        public FollowingCounts followingCounts { get; set; }
        public int groupCount { get; set; }
        public string id { get; set; }
        public string lastName { get; set; }
        public string name { get; set; }
        public List<PhoneNumber> phoneNumbers { get; set; }
        public Photo photo { get; set; }
        public object thanksReceived { get; set; }
        public string title { get; set; }
        public string userType { get; set; }
        public string username { get; set; }
    }   
}