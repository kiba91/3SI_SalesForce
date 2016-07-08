using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace MVC._3SI.SalesForce.Infrastructure
{
    public class ApiWebRequest
    {
        public string Url { get; set; }
        public string Method { get; set; }

        public ApiWebRequest(string url, string method) {
            Url = url;
            Method = method;
        }

        public ApiWebRequest(string url) {
            Url = url;
            Method = "GET";
        }

        public string DoRequest()
        {
            HttpWebRequest request = null;
            try
            {
                request = System.Net.WebRequest.Create(Url) as HttpWebRequest;
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
            catch (WebException) { throw; }
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