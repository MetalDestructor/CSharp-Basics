using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class DivideBySevenAndFive
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number you want to check : ");
            int number = int.Parse(Console.ReadLine());
            bool boolNumber =  ((number % 7 == 0) && (number % 5 == 0));
            if (boolNumber == true)
            {
                Console.WriteLine("This number can be devided by 7 and 5 in the same time");
            }
            else
            {
                Console.WriteLine("This number cannot be devided by 7 and 5 in the same time");
            }

        }
    }
}
