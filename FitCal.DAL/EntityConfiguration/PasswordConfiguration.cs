using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using FitCal.DATA.Entities;

namespace FitCal.DAL.EntityConfiguration
{
    public class PasswordConfiguration : EntityTypeConfiguration<Password>
    {
        public PasswordConfiguration()
        {
            ToTable("Passwords");
            HasKey(p => p.PasswordId);
            Property(p => p.PasswordId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Text).IsRequired().HasColumnName("Şifre");
            Property(p => p.CreatedDate).IsRequired().HasColumnName("Oluşturulma Tarihi");
            Property(p => p.SecurityWord).IsRequired().HasMaxLength(50).HasColumnName("Güvenlik Cevabı");
            

            //a password belongs to one user
            HasRequired(p => p.User).WithRequiredDependent(u => u.Password).Map(m => m.MapKey("UserId"));
        }
    }
}
