using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using FitCal.DATA.Entities;

namespace FitCal.DAL.EntityConfiguration
{
    public class MealConfiguration : EntityTypeConfiguration<Meal>
    {
        public MealConfiguration()
        {
            ToTable("Meals");
            HasKey(m => m.MealId);
            Property(m => m.MealId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(m => m.Name).IsRequired().HasMaxLength(50).HasColumnName("Öğün Adı");
            Property(m => m.Calories).IsRequired().HasColumnName("Toplam Kalori");
            Property(m => m.Notes).IsOptional().HasColumnName("Notlar");
            Property(m => m.CreatedDate).IsRequired().HasColumnName("Oluşturulma Tarihi");

            //a meal has many foods
            HasMany(m => m.Foods).WithMany(f => f.Meals).Map(m =>
            {
                //m.ToTable("Öğün Besinleri");
                m.MapLeftKey("MealId");
                m.MapRightKey("FoodId");
            });

            //a meal belongs to a user
            HasRequired(m => m.User).WithMany(u => u.Meals).HasForeignKey(m => m.UserId);
        }
    }
}