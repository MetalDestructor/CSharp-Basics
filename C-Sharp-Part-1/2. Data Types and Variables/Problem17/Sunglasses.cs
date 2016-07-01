using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem17
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (n % 2 == 0)
            {
                n = int.Parse(Console.ReadLine());
            }
            int n2 = n / 2;

            Console.WriteLine("*".PadLeft(n * 2, '*') + " ".PadLeft(n) + "*".PadLeft(n * 2, '*'));
            if (n > 3)
            {
                for (int i = 0; i < (int)n2 - 1; i++)
                {
                    Console.WriteLine("*" + "*".PadLeft((n * 2) - (n % 2), '\u002F') + " ".PadLeft(n) + "*" +"*".PadLeft((n * 2) - (n % 2), '\u002F'));
                }
            }
            Console.WriteLine("*" + "*".PadLeft((n * 2) - (n % 2), '\u002F') + "|".PadLeft(n, '|') + "*" + "*".PadLeft((n * 2) - (n % 2), '\u002F'));
            if (n > 3)
            {
                for (int i = 0; i < (int)n2 -1; i++)
                {
                    Console.WriteLine("*" + "*".PadLeft((n * 2) - (n % 2), '\u002F') + " ".PadLeft(n) + "*" + "*".PadLeft((n * 2) - (n % 2), '\u002F'));
                }
            }
            Console.WriteLine("*".PadLeft(n * 2, '*') + " ".PadLeft(n) + "*".PadLeft(n * 2, '*'));
        }
    }
}
