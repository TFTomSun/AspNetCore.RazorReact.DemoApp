using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TomSun.AspNetCore.RazorReact.DemoApp.Views.Shared.Components.Clock
{
    public class Clock : ReactViewComponent<Clock, object, ClockViewModel>
    {

        public override async Task<IViewComponentResult> InvokeAsync(object parameter)
        {
            return await this.DoInvokeAsync(parameter);
        }
    }
}