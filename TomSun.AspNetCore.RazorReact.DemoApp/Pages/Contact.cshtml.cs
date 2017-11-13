using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TomSun.AspNetCore.RazorReact.DemoApp.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            this.Message = "Your contact page.";
        }
    }
}
