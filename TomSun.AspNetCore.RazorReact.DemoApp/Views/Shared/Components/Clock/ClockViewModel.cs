using System;
using System.Threading;

namespace TomSun.AspNetCore.RazorReact.DemoApp.Views.Shared.Components.Clock
{
    public class ClockViewModel : ReactViewModel<ClockViewModel>
    {
        private readonly Timer _timer;
        public string Title => "Server side";
        public string ServerTime => DateTime.Now.TimeOfDay.ToString(@"hh\:mm\:ss");

        public ClockViewModel()
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