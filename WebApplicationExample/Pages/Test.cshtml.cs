using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationExample.Models.Setting_Models;

namespace WebApplicationExample.Pages
{
    public class TestModel : PageModel
    {
        public string ConnectionString { get; set; }

        public TestModel(DefaultConnectionSettings _connectionSettings)
        {
            ConnectionString = _connectionSettings.ConnectionString;
        }

        public void OnGet()
        {
        }
    }
}
