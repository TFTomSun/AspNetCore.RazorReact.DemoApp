using System.Threading.Tasks;
using DotNetify;
using Microsoft.AspNetCore.Mvc;

namespace TomSun.AspNetCore.RazorReact.DemoApp.Views.Shared.Components.TextBox
{
    public class TextBox : ReactViewComponent<TextBox, TextBox.Props, BaseVM>
    {
        public class Props
        {
            public string Value{ get; set; }
            public string PlaceHolder { get; set; }
            public object Changed { get; set; }
            public string Label { get; set; }
        }

        public override async Task<IViewComponentResult> InvokeAsync(Props parameter)
        {
            return await this.DoInvokeAsync(parameter);
        }
    }
}