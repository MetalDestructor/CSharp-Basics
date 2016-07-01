using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers:");
            Console.Write("a = ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            float c = float.Parse(Console.ReadLine());

            Console.Write(String.Format("{0:X}", a).PadRight(3));
            Console.Write("|" + Convert.ToString(a, 2).PadLeft(10,'0') + " |");
            Console.Write(String.Format("{0:0.00}", b).PadLeft(3));
            Console.Write(("|" + String.Format("{0:0.000}", c) + " |").PadRight(3));
            Console.WriteLine();
        }
    }
}