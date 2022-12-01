using System.Data.Entity;
using FitCal.DATA.Entities;

namespace FitCal.DAL.Strategy
{
    public class PasswordStrategy : CreateDatabaseIfNotExists<FitCalContext>
    {
        protected override void Seed(FitCalContext context)
        {
            //assign password to admin
            Password password = new Password()
            {
                Text = "123456",
                CreatedDate = System.DateTime.Now,
                SecurityQuestion = "İlkokul öğretmeninizin adı nedir?",
                SecurityWord = "Ayşe",
                User = context.Users.Find(1)
            };

            context.Passwords.Add(password);
        }
    }
}