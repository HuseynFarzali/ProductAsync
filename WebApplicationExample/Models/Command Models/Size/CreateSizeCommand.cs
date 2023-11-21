using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationExample.Models.Command_Models.Size
{
    public class CreateSizeCommand
    {
        [Required]
        [Display(Name = "Size Name")]
        public string Name { get; set; }
    }
}
