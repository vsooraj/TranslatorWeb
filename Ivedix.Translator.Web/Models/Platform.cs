using System.ComponentModel.DataAnnotations;

namespace Ivedix.Translator.Web.Models
{
    public class Platform
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Platfrom name is required")]
        public string Name { get; set; }

    }
}
