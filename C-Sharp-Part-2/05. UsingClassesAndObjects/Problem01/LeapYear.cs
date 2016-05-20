using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());

            if (year%4 == 0)
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }
    }
}
