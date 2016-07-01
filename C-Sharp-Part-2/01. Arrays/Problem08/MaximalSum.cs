using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem08
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int maxSum = 0;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
                if (maxSum < sum)
                {
                    maxSum = sum;
                }
                else if(sum < 0)
                {
                    sum = 0;
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
