using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem07
{
    class ReverseNumber
    {
        static void reverse(double n)
        {
            string num = new string(n.ToString().Reverse().ToArray());
            Console.WriteLine(num);
        }
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            reverse(n);
        }
    }
}
