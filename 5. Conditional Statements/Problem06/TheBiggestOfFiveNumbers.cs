using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    class TheBiggestOfFiveNumbers
    {
        static void Main(string[] args)
        {
            double[] arr = new double[5];
            arr[0] = double.Parse(Console.ReadLine());
            arr[1] = double.Parse(Console.ReadLine());
            arr[2] = double.Parse(Console.ReadLine());
            arr[3] = double.Parse(Console.ReadLine());
            arr[4] = double.Parse(Console.ReadLine());

            double max = arr[0];

            for (int i = 0; i < 5; i++)
            {
                if (max<arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
