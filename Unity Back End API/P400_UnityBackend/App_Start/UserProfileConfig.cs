using P400_UnityBackend.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace P400_UnityBackend.App_Start
{
    public class UserProfileConfig : EntityTypeConfiguration<UserProfileModel>
    {
        public UserProfileConfig() : base()
        {
            HasKey(p => p.UserName);

            ToTable("UserProfile");
        }
    }
}