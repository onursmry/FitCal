using System.Data.Entity.ModelConfiguration;
using FitCal.DATA.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;

namespace FitCal.DAL.EntityConfiguration
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("Users");
            HasKey(u => u.UserId);
            Property(u => u.UserId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(u => u.CreatedDate).IsRequired().HasColumnName("Oluşturulma Tarihi");
            Property(u => u.FirstName).IsRequired().HasMaxLength(50).HasColumnName("Ad");
            Property(u => u.LastName).IsRequired().HasMaxLength(50).HasColumnName("Soyad");
            Property(u => u.Email).IsRequired().HasMaxLength(250).HasColumnName("Email");
            HasIndex(u => u.Email).IsUnique();
            Property(u => u.BirthDate).HasColumnName("Doğum Tarihi").IsRequired();
            Property(u => u.Height).IsRequired().HasColumnName("Boy");
            Property(u => u.Weight).IsRequired().HasColumnName("Kilo");
            Property(u => u.UserType).HasColumnName("Kullanıcı Tipi");
            Property(u => u.IsActive).HasColumnName("Durumu");

            //a user can have many meals
            HasMany(u => u.Meals).WithRequired(m => m.User).HasForeignKey(m => m.UserId).WillCascadeOnDelete(false);

            //a user has one password
            HasRequired(u => u.Password).WithRequiredPrincipal(p => p.User);
        }
    }
}