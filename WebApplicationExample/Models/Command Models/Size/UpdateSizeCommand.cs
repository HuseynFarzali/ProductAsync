using System.ComponentModel.DataAnnotations;

namespace WebApplicationExample.Models.Command_Models.Size
{
    public class UpdateSizeCommand
    {
        [Required]
        [Display(Name = "New Size Name")]
        public string Name { get; set; }
    }
}
