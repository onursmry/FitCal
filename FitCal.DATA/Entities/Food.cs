using System.Collections.Generic;

namespace FitCal.DATA.Entities
{
    public class Food:BaseEntity
    {
        public int FoodId { get; set; }
        public string Name { get; set; }
        public double Calories { get; set; }

        //food photo
        public string FoodPhotoPath { get; set; }
        public byte[] FoodPhoto { get; set; }

        //Navigation Properties
        public Category Category { get; set; }
        public int CategoryId { get; set; }

        //a food belongs to many meals
        public ICollection<Meal> Meals { get; set; }
    }
}