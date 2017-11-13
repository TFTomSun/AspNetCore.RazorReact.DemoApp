using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TomSun.AspNetCore.RazorReact.DemoApp.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            this.Message = "Your application description page.";
        }
    }
}
