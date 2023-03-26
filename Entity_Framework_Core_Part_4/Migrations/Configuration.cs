namespace Entity_Framework_Core_Part_4.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Entity_Framework_Core_Part_4.DataModel.CountrisContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Entity_Framework_Core_Part_4.DataModel.CountrisContext";
        }

        protected override void Seed(Entity_Framework_Core_Part_4.DataModel.CountrisContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
