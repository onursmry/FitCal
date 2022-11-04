namespace FitCal.DAL.Migrations
{
   
    using System.Data.Entity.Migrations;
    

    internal sealed class Configuration : DbMigrationsConfiguration<FitCal.DAL.FitCalContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FitCal.DAL.FitCalContext context)
        {
            //  This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
