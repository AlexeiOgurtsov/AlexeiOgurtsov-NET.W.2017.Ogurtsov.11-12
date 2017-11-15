using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Events;

namespace ConsoleUI
{
    class TimerMessage1
    {
        public TimerMessage1(TimerWatch timer)
        {
            timer.TimerStoped += Message;
        }

        private void Message(object o, EventArgs args)
        {
            Console.WriteLine("Timer Message 1");
        }
    }
}