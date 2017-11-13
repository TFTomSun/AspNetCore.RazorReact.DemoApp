using System;
using System.Threading;

namespace TomSun.AspNetCore.RazorReact.DemoApp
{
    public class HelloWorld2 : ReactViewModel<HelloWorld2>
    {
        private Timer _timer;
        public string Greetings => "Hello World 2!";
        public DateTime ServerTime => DateTime.Now;

        public HelloWorld2()
        {
            this._timer = new Timer(state =>
            {
                this.Changed(nameof(this.ServerTime));
                this.PushUpdates();
            }, null, 0, 1000);
        }
        public override void Dispose() => this._timer.Dispose();
    }
    public class HelloWorld : ReactViewModel<HelloWorld>
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
