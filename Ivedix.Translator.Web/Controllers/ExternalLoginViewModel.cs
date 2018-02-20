using System.ComponentModel.DataAnnotations;

namespace Ivedix.Translator.Web.ViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}