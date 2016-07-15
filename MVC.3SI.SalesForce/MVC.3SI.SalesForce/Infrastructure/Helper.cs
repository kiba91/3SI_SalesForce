using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MVC._3SI.SalesForce.Infrastructure
{
    public class Helper
    {
        public static string GetAppSettingValue(string key) {
            var value = System.Configuration.ConfigurationManager.AppSettings[key];
            if (value == null) {
                value = string.Format("Could not find setting '{0}'.", key);
            }
            return value;
        }

        /// <summary>
        /// This is a different Url Encode implementation since the default .NET one outputs the percent encoding in lower case.
        /// While this is not a problem with the percent encoding spec, it is used in upper case throughout oChatterRESTAPI
        /// </summary>
        public static string UrlEncode(string value)
        {
            string m_sUnreservedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~";
            StringBuilder result = new StringBuilder();
            try
            {
                foreach (char symbol in value)
                {
                    if (m_sUnreservedChars.IndexOf(symbol) != -1)
                    {
                        result.Append(symbol);
                    }
                    else
                    {
                        result.Append('%' + String.Format("{0:X2}", (int)symbol));
                    }
                }

                return result.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }
        
    }
}