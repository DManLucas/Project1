namespace Memberships.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Memberships.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;

            ///<summary>
            ///Should be used so that it tells the program I am not okay with data loss and should be false
            ///but for this program i set it to true 
            ///</summary>
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Memberships.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
