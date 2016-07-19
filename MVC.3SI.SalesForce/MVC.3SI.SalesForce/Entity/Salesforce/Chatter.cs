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

    public class Actor
    {
        public object additionalLabel { get; set; }
        public string communityNickname { get; set; }
        public string companyName { get; set; }
        public string displayName { get; set; }
        public string firstName { get; set; }
    }


    public class Parent
    {
        public string displayName { get; set; }
        public string firstName { get; set; }
        public string id { get; set; }
    }

    public class Element
    {
        public Actor actor { get; set; }
        public string id { get; set; }
        public Parent parent { get; set; }
    }

    public class ChatterRootObject
    {
        public object currentPageToken { get; set; }
        public List<Element> elements { get; set; }
    }
}