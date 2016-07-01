using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class MaximalIncreasingSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int maximal = 0;
            int br = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i]  < arr[i + 1])
                {
                    ++br;
                }
                else if (arr[i] >= arr[i + 1])
                {
                    if (maximal < br)
                    {
                        maximal = br;
                    }
                    br = 0;
                }
            }
            Console.WriteLine(maximal + 1);

        }
    }
}
