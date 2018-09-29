using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using webAppl.Models;

namespace webAppl.Infastructure
{
    public class AppIdentyDbContext:IdentityDbContext<AppUser>
    {
        public AppIdentyDbContext():base("name=IdentityDb")
        {   
        }

        static AppIdentyDbContext()
        {
            Database.SetInitializer<AppIdentyDbContext>( new IdentityDbInit());
        }

        public static AppIdentyDbContext Create()
        {
            return new AppIdentyDbContext();
        }
    }

    public class IdentityDbInit:DropCreateDatabaseIfModelChanges<AppIdentyDbContext>
    {
        protected override void Seed(AppIdentyDbContext context)
        {
            PerformInitialSeed(context);
            base.Seed(context);
        }

        public void PerformInitialSeed(AppIdentyDbContext context)
        {

        }
    }
}