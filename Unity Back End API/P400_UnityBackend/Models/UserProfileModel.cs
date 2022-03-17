using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P400_UnityBackend.Models
{
    public class UserProfileModel : ApplicationUser
    {
        public string UserData { get; set; }

    }
}