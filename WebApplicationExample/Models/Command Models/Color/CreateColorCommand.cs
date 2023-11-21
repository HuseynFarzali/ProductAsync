using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace WebApplicationExample.Models.Command_Models.Color
{
    public class CreateColorCommand
    {
        [Required]
        [Display(Name = "Color Name")]
        public string Name { get; set; }
    }
}
