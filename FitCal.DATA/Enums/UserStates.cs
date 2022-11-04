using System.ComponentModel.DataAnnotations;

namespace FitCal.DATA.Enums
{
    public enum UserStates
    {
        [Display(Name = "Aktif")]
        Active =0,
        [Display(Name = "Pasif")]
        Passive = 1
    }
}