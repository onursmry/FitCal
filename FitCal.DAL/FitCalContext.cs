using System;
using System.Data.Entity;
using FitCal.DAL.EntityConfiguration;
using FitCal.DATA.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FitCal.DAL
{
    public class FitCalContext : DbContext
    {
        public FitCalContext() : base("connectionString")
      
        {
            //create database if not exists
            Database.SetInitializer<FitCalContext>(new CreateDatabaseIfNotExists<FitCalContext>());
        }

        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Password> Passwords { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new FoodConfiguration());
            modelBuilder.Configurations.Add(new MealConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new PasswordConfiguration());
            

            //plural to singular
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //SQL date time format
            modelBuilder.Properties<DateTime>().Configure(c => c.HasColumnType("datetime2"));
            modelBuilder.Properties<DateTime>().Configure(c => c.HasPrecision(0));
        }
    }
}

