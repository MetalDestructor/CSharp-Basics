using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class NumbersNotDivisible
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
