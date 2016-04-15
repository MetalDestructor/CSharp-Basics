using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    class SumOfnNumbers
    {
        static void Main(string[] args)
        {
            double sum = 0;
            Console.Write("How manu number do you want? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("n" + (i + 1)+ "= ");
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Sum is: {sum}");
        }
    }
}
