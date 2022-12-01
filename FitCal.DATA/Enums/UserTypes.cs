using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FitCal.DATA.Enums
{
    public enum UserTypes
    {
        [Display(Name ="Admin")]
        Admin =1,
        [Display(Name = "User")]
        User = 2
    }
}