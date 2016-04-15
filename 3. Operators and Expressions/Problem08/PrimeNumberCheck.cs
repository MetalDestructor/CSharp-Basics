using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            bool result = true;
            int num = int.Parse(Console.ReadLine());
            if (num == 0 || num == 1)
            {
                result = false;
            }
            else if (num == 2 || num == 3 || num == 5 || num == 7 )
            {
                result = true;
            }
            else if (num % 2 == 0 || num % 3 == 0 || num % 5 == 0 || num % 7 == 0)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            if (result == true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
