using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Net.Mail;
using FitCal.DATA.Entities;
using FitCal.DATA.Enums;


namespace FitCal.DAL.Strategy
{
    public class UserStrategy : CreateDatabaseIfNotExists<FitCalContext>
    {
       
        protected override void Seed(FitCalContext context)
        {
            
            //create admin and add to database
            User admin = new User()
            {
                UserId = 1,
                FirstName = "Admin",
                LastName = "Admin",
                Email = "admin@fitcal.com",
                UserType = UserTypes.Admin,
                CreatedDate = DateTime.Now,
                BirthDate = new DateTime(1990, 09, 14),
                Height = 180,
                Weight = 70,
                Gender = Genders.Erkek,
                IsActive = UserStates.Active,
            };

            context.Users.Add(admin);
            
        }
    }
}

