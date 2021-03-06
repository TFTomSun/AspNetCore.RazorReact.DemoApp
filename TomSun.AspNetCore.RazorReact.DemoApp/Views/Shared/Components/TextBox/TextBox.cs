﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TomSun.AspNetCore.RazorReact.DemoApp.Views.Shared.Components.TextBox
{


    public class TextBox : ReactViewComponent<TextBox, TextBox.ReactView, TextBox.Properties, TextBox.State>
    {
            
        public class State : Properties
        {
        }

        public class Properties
        {
            public string Value { get; set; }
            public string PlaceHolder { get; set; }
            public string Label { get; set; }
            public ActionDefinition<string> OnChange { get; set; }
        }

        public async Task<IViewComponentResult> InvokeAsync(string value, string placeHolder, string label,
            ActionDefinition<string> onChange = null)
        {
            return await this.DoInvokeAsync((value, placeHolder, label, onChange));
        }

        public class ReactView : BaseView
        {

            public ActionDefinition<string> Alert()
            {
                return ActionDefinition<string>.Create(v => alert(v));
            }

            public FunctionDefinition<string> GetLabelText()
            {
                return this.Call(() => this.props.Label);
            }
        }
    }
}