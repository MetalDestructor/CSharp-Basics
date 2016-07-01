using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class OperationsOfNNumbers
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            double[] arr = new double[num];
            for (int i = 0; i < num; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }
            double min = arr[0];
            for (int i = 0; i < num; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            double max = arr[0];
            for (int i = 0; i < num; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            double sum = 0;
            for (int i = 0; i < num; i++)
            {
                sum += arr[i];
            }
            double avarage = sum / (double)num;
            Console.WriteLine("min={0:F2}", min);
            Console.WriteLine("max={0:F2}", max);
            Console.WriteLine("sum={0:F2}", sum);
            Console.WriteLine("avg={0:F2}", avarage);
        }
    }
}
