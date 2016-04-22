using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\u00a9".PadLeft(4));
            Console.WriteLine("\u00a9".PadLeft(3) + "\u00a9".PadLeft(2));
            Console.WriteLine("\u00a9".PadLeft(2) + "\u00a9".PadLeft(4));
            Console.WriteLine("\u00a9" + "\u00a9".PadLeft(2) + "\u00a9".PadLeft(2) + "\u00a9".PadLeft(2));
        }
    }
}
