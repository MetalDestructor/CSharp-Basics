using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int result = 0;
            switch (a)
            {
                case 1:
                case 2:
                case 3:
                    result = a * 10;
                    break;
                case 4:
                case 5:
                case 6:
                    result = a * 100;
                    break;
                case 7:
                case 8:
                case 9:
                    result = a * 1000;
                    break;
                default:
                    Console.WriteLine("Invalid score");
                    break;
            }
            if (a > 0 && a < 10)
            {
                Console.WriteLine(result);
            }
        }
    }
}
