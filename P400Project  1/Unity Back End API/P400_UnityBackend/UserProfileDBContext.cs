using Microsoft.AspNet.Identity.EntityFramework;
using P400_UnityBackend.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace P400_UnityBackend
{
    public class UserProfileDBContext : IdentityDbContext<UserProfileModel>
    {
        public UserProfileDBContext()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}