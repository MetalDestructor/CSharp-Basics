using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Problem01.Tests
{
    using Timer;
    public class TimerTest
    {
        public static void Test()
        {
            var timer = new Timer(1000);
            var subscriber = new Subscriber(10);
            subscriber.Listen(timer);

            timer.Start();
        }
    }
}
