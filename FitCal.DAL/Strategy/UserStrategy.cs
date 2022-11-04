using System;
using System.Data.Entity;
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
                BirthDate = new DateTime(2000, 01, 01),
                Height = 180,
                Weight = 70,
                Gender = Genders.Erkek,
                IsActive = UserStates.Active,

                Password = new Password()
                {
                    Text = "123456",
                    CreatedDate = DateTime.Now,
                    SecurityQuestion = "İlkokul öğretmeninizin adı nedir?",
                    SecurityWord = "FitCal",
                }

            };

            context.Users.Add(admin);

        }
    }
}

