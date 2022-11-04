using System.Data.Entity.ModelConfiguration;
using FitCal.DATA.Entities;

namespace FitCal.DAL.EntityConfiguration
{
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            // Primary Key
            HasKey(t => t.CategoryId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Categories");
            Property(t => t.CategoryId).HasColumnName("CategoryId").HasColumnName("Kategori Id");
            Property(t => t.Name).HasColumnName("Kategori Adı");

            //A category has many foods
            HasMany(t => t.Foods).WithRequired(t => t.Category).HasForeignKey(t => t.CategoryId);
        }
    }
}