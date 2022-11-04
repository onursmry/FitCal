using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using FitCal.DATA.Entities;

namespace FitCal.DAL.EntityConfiguration
{
    public class FoodConfiguration:EntityTypeConfiguration<Food>
    {
        public FoodConfiguration()
        {
            ToTable("Foods");
            HasKey(f => f.FoodId);
            Property(f => f.FoodId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(f => f.Name).IsRequired().HasMaxLength(50).HasColumnName("Besin Adı");
            Property(f => f.Calories).IsRequired().HasColumnName("Kalori");
            Property(f => f.FoodPhotoPath).IsOptional().HasColumnName("Besin Fotoğrafı Yolu");
            Property(f => f.FoodPhoto).IsOptional().HasColumnType("image").HasColumnName("Besin Fotoğrafı");
            Ignore(f => f.CreatedDate);

            //a food belongs to a category
            HasRequired(f => f.Category).WithMany(c => c.Foods).HasForeignKey(f => f.CategoryId).WillCascadeOnDelete(false);
        }
    }
}