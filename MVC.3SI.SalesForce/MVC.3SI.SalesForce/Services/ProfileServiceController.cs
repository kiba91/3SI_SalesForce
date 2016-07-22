using System.Web.Http;

namespace MVC._3SI.SalesForce.Services
{
    public class ProfileServiceController : ApiController
    {
        // GET api/profileservice
        public string Get()
        {
            //return profile.GetProfile();
            //profile = Getprofile.GetProfile();
            //var getProfile = new ProfileModel(Convert.ToString(Constants.RefreshAccessTokenSession));
            //   return getProfile.GroupJson;
            return "value";
        }

        // GET api/chatterservice/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/chatterservice
        public void Post([FromBody]string value)
        {
        }

        // PUT api/chatterservice/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/chatterservice/5
        public void Delete(int id)
        {
        }
    }
}