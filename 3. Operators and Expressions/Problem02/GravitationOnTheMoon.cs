using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your weight : ");
            double number = double.Parse(Console.ReadLine());
            double weightOnMoon = (17.0 * number) / 100;
            Console.WriteLine("Your weight on the Moon will be : {0}", weightOnMoon);

        }
    }
}
