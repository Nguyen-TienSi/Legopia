using System.ComponentModel.DataAnnotations;

namespace Legopia.Models.ViewModels
{
    public class RegistrationPersonalInfoViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;
    }
}
