using System;
using System.Collections.Generic;
using System.Data.Entity;
using FitCal.DATA.Entities;

namespace FitCal.DAL.Strategy
{
    public class CategoryStrategy : CreateDatabaseIfNotExists<FitCalContext>
    {
        protected override void Seed(FitCalContext context)
        {
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
                }
            };

            context.Categories.AddRange(categories);
        }
    }
}