using System;
using System.IO;
using System.Net;
using System.Data;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Text;

namespace MVC._3SI.SalesForce.Infrastructure
{
    public class ApiWebRequest
    {
        public string Url { get; set; }
        public string Method { get; set; }
        public List<KeyValuePair<string, string>> HeaderSettings { get; set; }
        public ApiWebRequest(string url, string method) {
            Url = url;
            Method = method;
        }
        
        public ApiWebRequest(string url) : this(url,Constants.Method.Get) {
        }


        public string DoRequest()
        {
            HttpWebRequest request = null;
            try
            {
                request = System.Net.WebRequest.Create(Url) as HttpWebRequest;
                if (Constants.Method.Post.Equals(Method,StringComparison.OrdinalIgnoreCase)) {
                    request.ContentType = "application/x-www-form-urlencoded";
                }
                //header settings
                if (HeaderSettings != null && HeaderSettings.Count > 0) {
                    foreach (var setting in HeaderSettings) {
                        if (request.Headers[setting.Key] != null)
                        {
                            request.Headers[setting.Key] = setting.Value;
                        }
                        else
                        {
                            request.Headers.Add(setting.Key,setting.Value);
                        }
                    }
                }
                request.Method = Method;
                request.ServicePoint.Expect100Continue = true;
                var response = GetWebResponse(request);
                request = null;
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string GetWebResponse(HttpWebRequest request)
        {
            StreamReader oResponseReader = null;
            WebResponse oWebResponse = null;
            Stream oResponseStream = null;
            try
            {
                ////To By pass ssl certification Authentication
                request.KeepAlive = false;
                request.ConnectionGroupName = Guid.NewGuid().ToString();
                ServicePointManager.ServerCertificateValidationCallback += SecureCertValCallBk;

                oWebResponse = request.GetResponse();
                oResponseStream = oWebResponse.GetResponseStream();
                oResponseReader = new StreamReader(oResponseStream);
                string m_sApiResponse = oResponseReader.ReadToEnd();
                return m_sApiResponse;
            }
            catch (WebException ex) {
                using (var stream = ex.Response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception) { throw; }
            finally
            {
                if (oWebResponse != null)
                    oWebResponse.Close();
            }
        }

        private bool SecureCertValCallBk(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors err)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}