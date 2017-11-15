using System;
using System.Threading;

namespace Events
{
    public class Timer
    {
        /// <summary>
        /// Event to be started after time is out
        /// </summary>
        public event EventHandler TimerStoped;

        /// <summary>
        /// Time
        /// </summary>
        private int time;

        /// <summary>
        /// Initializes an instance of the timer with the passed parameter.
        /// </summary>
        /// <param name="time">Starting time for Timer (in sec)</param>
        public Timer(int time)
        {
            this.time = time;
        }

        /// <summary>
        /// Starting timer
        /// </summary>
        public void Start()
        {
            Thread.Sleep(time * 1000);
            TimeIsOut(this, new EventArgs());

        }

        /// <summary>
        /// The end of time
        /// </summary>
        private void TimeIsOut(object o, EventArgs args)
        {
            TimerStoped(o, args);
        }
    }
}
