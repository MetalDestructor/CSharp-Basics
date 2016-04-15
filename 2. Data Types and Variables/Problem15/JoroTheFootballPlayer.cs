using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15
{
    class JoroTheFootballPlayer
    {
        static void Main(string[] args)
        {
            double plays = 0;
            int weekends = 52;

            string leapYear = Console.ReadLine();
            double numberHolidays = double.Parse(Console.ReadLine());
            double hometownWeekends = double.Parse(Console.ReadLine());

            double normalWeekends = weekends - hometownWeekends;
            double playsWeekends = (normalWeekends * 2) / 3;
            double playsHolidays = numberHolidays * 0.5;

            if (leapYear == "t")
            {
                plays = hometownWeekends + playsWeekends + playsHolidays + 3;
            }
            else
            {
                plays = hometownWeekends + playsWeekends + playsHolidays;
            }

            Console.WriteLine(Math.Truncate(plays));
        }
    }
}
