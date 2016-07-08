using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}