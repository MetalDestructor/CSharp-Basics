//TODO
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class SumOf5Numbers
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double n1 = Convert.ToDouble(input[0]);
            double n2 = Convert.ToDouble(input[1]);
            double n3 = Convert.ToDouble(input[2]);
            double n4 = Convert.ToDouble(input[3]);
            double n5 = Convert.ToDouble(input[4]);

            double sum = n1 + n2 + n3 + n4 + n5;
            Console.WriteLine(sum);
            //double n1 = int.Parse(Console.ReadLine());
            //Console.Write("\n");
            //double n2 = int.Parse(Console.ReadLine());
            //Console.Write("\b");
            //double n3 = int.Parse(Console.ReadLine());
            //Console.Write("\b");
            //double n4 = int.Parse(Console.ReadLine());
            //Console.Write("\b");
            //double n5 = int.Parse(Console.ReadLine());
            //Console.Write("\b");

        }
    }
}
