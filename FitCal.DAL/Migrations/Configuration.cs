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
            List<Category> categories = new List<Category>()
            {
                new Category()
                {
                    CategoryId = 1,
                    Name = "Et ve Balık",
                    CreatedDate = DateTime.Now
                },
                new Category()
                {
                    CategoryId = 2,
                    Name = "Sebze",
                    CreatedDate = DateTime.Now
                },
                new Category()
                {
                    CategoryId = 3,
                    Name = "Meyve",
                    CreatedDate = DateTime.Now
                },
                new Category()
                {
                    CategoryId = 4,
                    Name = "Süt ve Süt Ürünleri",
                    CreatedDate = DateTime.Now
                },
                new Category()
                {
                    CategoryId = 5,
                    Name = "Tatlı",
                    CreatedDate = DateTime.Now
                },
                new Category()
                {
                    CategoryId = 6,
                    Name = "İçecek",
                    CreatedDate = DateTime.Now
                },
                new Category()
                {
                    CategoryId = 7,
                    Name = "Diğer",
                    CreatedDate = DateTime.Now
                },
                new Category()
                {
                    CategoryId = 8,
                    Name = "Ekmek ve Tahıl Grubu",
                    CreatedDate = DateTime.Now
                }

            };

            context.Categories.AddRange(categories);

            #region 1st admin

            User admin1 = new User()
            {
                FirstName = "Serap",
                LastName = "Çınar",
                Email = "serapcinar@fitcal.com",
                UserType = UserTypes.Admin,
                CreatedDate = DateTime.Now,
                IsActive = UserStates.Active,
                Gender = Genders.Kadın,
                Height = 170,
                Weight = 55,
                BirthDate = new DateTime(1990, 11, 20),

                Password = new Password()
                {
                    Text = "240BE518FABD2724DDB6F04EEB1DA5967448D7E831C08C8FA822809F74C720A9",
                    CreatedDate = DateTime.Now,
                    SecurityQuestion = "İlkokul öğretmeninizin adı nedir?",
                    SecurityWord = "Ayşe"
                }
            };

            context.Users.Add(admin1); //1st admin

            #endregion

            #region 2nd admin

            User admin2 = new User()
            {
                FirstName = "Fatih",
                LastName = "Yılmaz",
                Email = "fatihyilmaz@fitcal.com",
                UserType = UserTypes.Admin,
                CreatedDate = DateTime.Now,
                Gender = Genders.Erkek,
                IsActive = UserStates.Active,
                Height = 180,
                Weight = 80,
                BirthDate = new DateTime(1996, 02, 03),

                Password = new Password()
                {
                    Text = "240BE518FABD2724DDB6F04EEB1DA5967448D7E831C08C8FA822809F74C720A9",
                    CreatedDate = DateTime.Now,
                    SecurityQuestion = "İlkokul öğretmeninizin adı nedir?",
                    SecurityWord = "Ayşe"
                }
            };

            context.Users.Add(admin2);

            #endregion

            #region 3rd admin

            User admin3 = new User()
            {
                FirstName = "Sinan",
                LastName = "Öztürk",
                Email = "asinanozturk@fitcal.com",
                UserType = UserTypes.Admin,
                CreatedDate = DateTime.Now,
                Gender = Genders.Erkek,
                IsActive = UserStates.Active,
                Height = 165,
                Weight = 70,
                BirthDate = new DateTime(1991, 7, 17),

                Password = new Password()
                {
                    Text = "240BE518FABD2724DDB6F04EEB1DA5967448D7E831C08C8FA822809F74C720A9",
                    CreatedDate = DateTime.Now,
                    SecurityQuestion = "İlkokul öğretmeninizin adı nedir?",
                    SecurityWord = "Ayşe"
                }
            };

            context.Users.Add(admin3);

            #endregion

            #region 4th admin

            User admin4 = new User()
            {
                FirstName = "Onur",
                LastName = "Esmeray",
                Email = "onuresmeray@fitcal.com",
                UserType = UserTypes.Admin,
                CreatedDate = DateTime.Now,
                Gender = Genders.Erkek,
                IsActive = UserStates.Active,
                Height = 181,
                Weight = 71,
                BirthDate = new DateTime(1990, 09, 14),

                Password = new Password()
                {
                    Text = "DD27D801BCF2E9C6FD9DEAC9AB5546131785962DA603195E499CE753C07F9E54",
                    CreatedDate = DateTime.Now,
                    SecurityQuestion = "İlkokul öğretmeninizin adı nedir?",
                    SecurityWord = "Ayşe"
                }
            };

            context.Users.Add(admin4);

            #endregion

            //List of foods
            List<Food> foods = new List<Food>()
            {
                new Food()
                {
                    FoodId = 1,
                    Name = "Dana Eti - 100 gr",
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                    Calories = 251
                },
                new Food()
                {
                FoodId = 2,
                Name = "Köfte - 1 adet",
                CategoryId = 1,
                CreatedDate = DateTime.Now,
                Calories = 59.9
            },
                new Food()
                {
                    FoodId = 3,
                    Name = "Tavuk (göğüs) - 100 gram",
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                    Calories = 108.7
                },
                new Food()
                {
                    FoodId = 4,
                    Name = "Palamut - 100 gram",
                    CategoryId = 1,
                    CreatedDate = DateTime.Now,
                    Calories = 168
                },
                new Food()
                {
                    FoodId = 5,
                    Name = "Domates - 100 gram",
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                    Calories = 17.4
                },
                new Food()
                {
                    FoodId = 6,
                    Name = "Patates - 100 gram",
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                    Calories = 71.2
                },
                new Food()
                {
                    FoodId = 7,
                    Name = "Muz - 100 gram",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                    Calories = 152.2
                },
                new Food()
                {
                    FoodId = 8,
                    Name = "Elma - 100 gram",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                    Calories = 58
                },
                new Food()
                {
                    FoodId = 9,
                    Name = "Yoğurt - 100 gram",
                    CategoryId = 4,
                    CreatedDate = DateTime.Now,
                    Calories = 65.7
                },
                new Food()
                {
                    FoodId = 10,
                    Name = "Bal - 100 gram",
                    CategoryId = 5,
                    CreatedDate = DateTime.Now,
                    Calories = 307
                },
                new Food()
                {
                    FoodId = 11,
                    Name = "Kola - 330 cl",
                    CategoryId = 6,
                    CreatedDate = DateTime.Now,
                    Calories = 149
                },
                new Food()
                {
                    FoodId = 12,
                    Name = "Su",
                    CategoryId = 6,
                    CreatedDate = DateTime.Now,
                    Calories = 0
                },
                new Food()
                {
                    FoodId = 13,
                    Name = "Çikolata (sütlü) - 100 gram",
                    CategoryId = 5,
                    CreatedDate = DateTime.Now,
                    Calories = 545.6
                },
                new Food()
                {
                    FoodId = 14,
                    Name = "Çikolata (bitter) - 100 gram",
                    CategoryId = 5,
                    CreatedDate = DateTime.Now,
                    Calories = 546
                },
                new Food()
                {
                    FoodId = 15,
                    Name = "Kuru Fasulye - 1 su bardağı",
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                    Calories = 227
                },
                new Food()
                {
                    FoodId = 16,
                    Name = "Kuru Soğan - 100 gram",
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                    Calories = 39.7
                },
                new Food()
                {
                    FoodId = 17,
                    Name = "Kuru Nane - 100 gram",
                    CategoryId = 2,
                    CreatedDate = DateTime.Now,
                    Calories = 356
                },
                new Food()
                {
                    FoodId = 18,
                    Name="Probis - 100 gram",
                    CategoryId = 7,
                    CreatedDate = DateTime.Now,
                    Calories = 490
                },
                new Food()
                {
                    FoodId = 19,
                    Name = "Kuru Kayısı - 100 gram",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                    Calories = 250
                },
                new Food()
                {
                    FoodId = 20,
                    Name = "Yulaf Ezmesi - 100 gram",
                    CategoryId = 8,
                    CreatedDate = DateTime.Now,
                    Calories = 370
                },
                new Food()
                {
                    FoodId = 21,
                    Name = "Yulaf Ekmeği - 1 dilim",
                    CategoryId = 8,
                    CreatedDate = DateTime.Now,
                    Calories = 51.5
                },
                new Food()
                {
                    FoodId = 22,
                    Name = "Beyaz Ekmek - 100 gram",
                    CategoryId = 8,
                    CreatedDate = DateTime.Now,
                    Calories = 63.9
                },
                new Food()
                {
                    FoodId = 23,
                    Name = "Tam Tahıllı Ekmek - 100 gram",
                    CategoryId = 8,
                    CreatedDate = DateTime.Now,
                    Calories = 226.3
                },
                new Food()
                {
                    FoodId = 24,
                    Name = "Kuru Kayısı - 100 gram",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                    Calories = 250
                },
                new Food()
                {
                    FoodId = 25,
                    Name = "Kuru Kayısı - 100 gram",
                    CategoryId = 3,
                    CreatedDate = DateTime.Now,
                    Calories = 250
                },
                new Food()
                {
                    FoodId = 26,
                    Name = "Ayran - 200 ml",
                    CategoryId = 6,
                    CreatedDate = DateTime.Now,
                    Calories = 71.2
                },
                new Food()
                {
                    FoodId = 27,
                    Name = "Kefir - 100 ml",
                    CategoryId = 6,
                    CreatedDate = DateTime.Now,
                    Calories = 132
                },
                new Food()
                {
                    FoodId = 28,
                    Name = "Soya Süt - 100 ml",
                    CategoryId = 6,
                    CreatedDate = DateTime.Now,
                    Calories = 33
                },
                new Food()
                {
                    FoodId = 29,
                    Name = "Mantı - 1 porsiyon",
                    CategoryId = 7,
                    CreatedDate = DateTime.Now,
                    Calories = 471
                },
                new Food()
                {
                    FoodId = 30,
                    Name = "Kırmızı Şarap - 100 cc",
                    CategoryId = 6,
                    CreatedDate = DateTime.Now,
                    Calories = 74.3
                },
                new Food()
                {
                    FoodId = 31,
                    Name = "Beyaz Şarap - 100 cc",
                    CategoryId = 6,
                    CreatedDate = DateTime.Now,
                    Calories = 72.2
                },
            };

            context.Foods.AddRange(foods);
        }
    }
}
