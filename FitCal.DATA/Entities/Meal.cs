using System.Collections.Generic;

namespace FitCal.DATA.Entities
{
    public class Meal : BaseEntity
    {
        public int MealId { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }

        //a meal can have many foods
        public ICollection<Food> Foods { get; set; }

        //a meal gets calories from Food
        public double Calories { get; set; }

        //a meal belongs to a user
        public User User { get; set; }
        public int UserId { get; set; }

    }
}