namespace Web_Site.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Web_Site.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "Web_Site.Models.ApplicationDbContext";
        }

        protected override void Seed(Web_Site.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            /*  var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
              string[] roleNames = { "Admin", "User" };
              IdentityResult roleResult;
              foreach (var roleName in roleNames)
              {
                  if (!RoleManager.RoleExists(roleName))
                  {
                      roleResult = RoleManager.Create(new IdentityRole(roleName));
                  }
              } 

             var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
             UserManager.AddToRole("4c08b733-28c0-4a64-af37-dd8368b47071", "Admin"); */
            
        }
    }
}
