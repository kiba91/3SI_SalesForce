﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC._3SI.SalesForce.Infrastructure
{
    public class Constants
    {
        public const string AccessTokenSession = "Access_Token";
        public const string RefreshAccessTokenSession = "RefreshAccess_Token";
        
        public class Method {
            public const string Get = "GET";
            public const string Post = "POST";
        }
    }
}