namespace MvcContacts.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcContacts.Models.MvcContactsDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "MvcContacts.Models.MvcContactsDB";
        }

        protected override void Seed(MvcContacts.Models.MvcContactsDB context)
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

            context.Restaurants.AddOrUpdate( r => r.Name,
                new Models.Restaurants { Name="Fellini",Street="Oslebshausener Str",Place="Bremen", RestaurantClass="Gourmet"  },
                new Models.Restaurants { Name = "Dubrovnik", Street = "Hauptstrasse", Place = "Wiesmoor",RestaurantClass="Gourmet" },
                new Models.Restaurants { Name = "Stavros", Street = "Obernstrasse", Place = "Bremen", RestaurantClass = "Gourmet" },
                new Models.Restaurants { Name = "China-Imbiss", Street = "Hauptstrasse", Place = "Aurich", RestaurantClass = "Gourmet" },
                new Models.Restaurants { Name = "Fellini", Street = "Oslebshausener Str", Place = "Bremen", RestaurantClass = "Gourmet" },
                new Models.Restaurants { Name = "Bayrisches Bierhaus", Street = "Theresienwiese", Place = "München", RestaurantClass = "Gourmet" }
                );
            for(int i = 0; i<1000;i++)
            {
                context.Restaurants.AddOrUpdate(
                    new Models.Restaurants { Name = i.ToString(), Place = "Nowhere", RestaurantClass = "Gourmet" });
            }
        }
    }
}
