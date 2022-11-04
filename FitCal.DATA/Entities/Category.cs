using System.Collections.Generic;

namespace FitCal.DATA.Entities
{
    public class Category:BaseEntity
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        //A category can have many foods
        public ICollection<Food> Foods { get; set; }
    }
}