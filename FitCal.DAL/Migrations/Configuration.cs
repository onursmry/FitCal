using System.Net.Mail;

namespace FitCal.DAL.Migrations
{
    using System.Collections.Generic;
    using System;
    using System.Data.Entity.Migrations;
    using DATA.Entities;
    using DATA.Enums;

    internal sealed class Configuration : DbMigrationsConfiguration<FitCal.DAL.FitCalContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(FitCal.DAL.FitCalContext context)
        {
            //  This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //List of categories  
        }
    }
}
