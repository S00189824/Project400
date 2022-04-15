using P400_UnityBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace P400_UnityBackend.Controllers
{
    [Authorize]
    [Route("API/UserProfile")]
    public class UserProfileController : ApiController
    {
        public string Get(string username)
        {
            using (var context = new UserProfileDBContext())
            {
                var query = context.Users.FirstOrDefault(x => x.UserName == username);

                return query == null ? "" : query.UserData;
            }
        }

        public IHttpActionResult Post ([FromBody] UserProfileModel userProfile)
        {
            using(var db = new UserProfileDBContext())
            {
                var result = db.Users.SingleOrDefault(b => b.UserName == userProfile.UserName);

                if(result != null)
                {
                    result.UserData = userProfile.UserData;
                    db.SaveChanges();
                }

                return Ok();
            }
        }
    }
}
