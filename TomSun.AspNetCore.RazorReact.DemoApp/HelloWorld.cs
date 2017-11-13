using System;
using System.Threading;
using TomSunn.DotNetify.SampleWebApp;

namespace TomSun.AspNetCore.RazorReact.DemoApp
{
    public class HelloWorld : ReactComponent<HelloWorld>
    {
        private Timer _timer;
        public string Greetings => "Hello World!";
        public DateTime ServerTime => DateTime.Now;

        public HelloWorld()
        {
            this._timer = new Timer(state =>
            {
                this.Changed(nameof(this.ServerTime));
                this.PushUpdates();
            }, null, 0, 1000);
        }
        public override void Dispose() => this._timer.Dispose();
    }

}
