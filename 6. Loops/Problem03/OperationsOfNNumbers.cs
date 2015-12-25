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

            int[] arr = new int[num];
            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int min = arr[0];
            for (int i = 0; i < num; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            int max = arr[0];
            for (int i = 0; i < num; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                sum += arr[i];
            }
            double avarage = sum / (double)num;
            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avarage = {0:0.00}", avarage);
        }
    }
}
