using System;

namespace Problem01.Timer
{
    public class TimerEventArgs : EventArgs
    {
        public TimerEventArgs()
        {
            this.Time = DateTime.Now;
        }
        public DateTime Time { get; private set; }
    }
}