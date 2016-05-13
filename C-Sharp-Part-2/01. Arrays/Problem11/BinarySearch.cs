using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    class BinarySearch
    {
        static int Search(int[] arr, int x)
        {
            int leftBound = 0;
            int rightBound = arr.Length - 1;
            while (leftBound <= rightBound)
            {
                int i = (leftBound + rightBound) / 2;
                if (arr[i] < x)
                {
                    leftBound = i + 1;
                }
                else if (arr[i] > x)
                {
                    rightBound = i;
                }
                else
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int j = 0; j < n; j++)
            {
                arr[j] = int.Parse(Console.ReadLine());
            }
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(Search(arr, x));
        }
    }
}
