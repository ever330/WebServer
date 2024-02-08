namespace WebServer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebServer.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebServer.Data.WebServerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebServer.Data.WebServerContext context)
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
            context.Users.AddOrUpdate(
              p => p.Id,
              new User { Id = "ever330", Password = "1234", Nickname = "Blanc", SignUpDate = DateTime.Now, LastLoginDate = DateTime.Now },
              new User { Id = "MilkFresh", Password = "1234", Nickname = "9L", SignUpDate = DateTime.Now, LastLoginDate = DateTime.Now }
            );
        }
    }
}
