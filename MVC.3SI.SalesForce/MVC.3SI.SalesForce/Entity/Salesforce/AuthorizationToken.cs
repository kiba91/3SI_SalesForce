using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC._3SI.SalesForce.Entity.Salesforce
{
    public class AuthorizationToken
    {
        public string id { get; set; }
        public string access_token { get; set; }
        
        //public Int64 issued_at { get; set; }
    }

    public class RefreshAuthorizationToken : AuthorizationToken {
        public string refresh_token { get; set; }
    }
}