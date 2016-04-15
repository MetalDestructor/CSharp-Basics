using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    class NumbersFrom1ToN
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i < num + 1; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
