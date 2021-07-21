using _200507_Exo07_Ecommerce.Objects;

namespace _200507_Exo07_Ecommerce.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_200507_Exo07_Ecommerce.Objects.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(_200507_Exo07_Ecommerce.Objects.ApplicationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            ApplicationContext db = new ApplicationContext();

            User adminUser = new User() {IsAdmin = true, Login = "admin", Password = "admin"};

            db.Users.AddOrUpdate(adminUser);
            db.SaveChanges();
        }
    }
}
