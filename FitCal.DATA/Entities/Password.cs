using System;
using System.ComponentModel.DataAnnotations;

namespace FitCal.DATA.Entities
{
    public class Password:BaseEntity
    {
        public int PasswordId { get; set; }
        [MinLength(8, ErrorMessage = "Şifre en az 8 karakter olmalıdır.")]
        public string Text { get; set; }
        public User User { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityWord { get; set; }
    }
}