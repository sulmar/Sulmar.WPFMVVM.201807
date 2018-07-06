namespace Sulmar.WPFMVVM.Shop.DbServices.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Sulmar.WPFMVVM.Shop.DbServices.ShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Sulmar.WPFMVVM.Shop.DbServices.ShopContext";
        }

        protected override void Seed(Sulmar.WPFMVVM.Shop.DbServices.ShopContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
