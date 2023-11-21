using System.ComponentModel.DataAnnotations;

namespace WebApplicationExample.Models.Command_Models.Color
{
    public class UpdateColorCommand
    {
        [Required]
        [Display(Name = "New Color Name")]
        public string Name { get; set; }
    }
}
