using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Events;

namespace ConsoleUI
{
    class TimerTest
    {
        static void Main(string[] args)
        {
            TimerWatch timer = new TimerWatch(10);

            TimerMessage1 timerMessage1 = new TimerMessage1(timer);
            TimerMessage2 timerMessage2 = new TimerMessage2(timer);

            timer.Start();

            TimerWatch timer2 = new TimerWatch(4);
            timerMessage1 = new TimerMessage1(timer2);
            timer2.Start();

            Console.ReadKey();
        }
    }
}
