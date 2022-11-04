using System;
using System.Collections.Generic;
using System.Data.Entity;
using FitCal.DATA.Entities;

namespace FitCal.DAL.Strategy
{
    public class FoodStrategy : CreateDatabaseIfNotExists<FitCalContext>
    {
        protected override void Seed(FitCalContext context)
        {
            //List of foods
            List<Food> foods = new List<Food>()
            {
                new Food()
                {
                    FoodId = 1,
                    Name = "Kıyma",
                    CategoryId = context.Categories.Find(1).CategoryId,
                    CreatedDate = DateTime.Now,
                    Calories = 200d
                },
                new Food()
                {
                    FoodId = 2,
                    Name = "Tavuk",
                    CategoryId = context.Categories.Find(1).CategoryId,
                    CreatedDate = DateTime.Now,
                    Calories = 150d
                },
                new Food()
                {
                    FoodId = 3,
                    Name = "Balık",
                    CategoryId = context.Categories.Find(1).CategoryId,
                    CreatedDate = DateTime.Now,
                    Calories = 100d
                },
                new Food()
                {
                    FoodId = 4,
                    Name = "Patates",
                    CategoryId = context.Categories.Find(2).CategoryId,
                    CreatedDate = DateTime.Now,
                    Calories = 100d
                },
                new Food()
                {
                    FoodId = 5,
                    Name = "Domates",
                    CategoryId = context.Categories.Find(2).CategoryId,
                    CreatedDate = DateTime.Now,
                    Calories = 50d
                },
                new Food()
                {
                    FoodId = 6,
                    Name = "Muz",
                    CategoryId = context.Categories.Find(3).CategoryId,
                    CreatedDate = DateTime.Now,
                    Calories = 50d
                },
                new Food()
                {
                    FoodId = 7,
                    Name = "Elma",
                    CategoryId = context.Categories.Find(3).CategoryId,
                    CreatedDate = DateTime.Now,
                    Calories = 50d
                },
                new Food()
                {
                    FoodId = 8,
                    Name = "Yoğurt",
                    CategoryId = context.Categories.Find(4).CategoryId,
                    CreatedDate = DateTime.Now,
                    Calories = 100d,
                },

            };

            context.Foods.AddRange(foods);
        }
    }
}