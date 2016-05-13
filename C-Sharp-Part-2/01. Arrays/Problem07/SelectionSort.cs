using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem07
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                max = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[max] > arr[j])
                    {
                        max = j;
                    }

                }
                int temp = arr[i];
                arr[i] = arr[max];
                arr[max] = temp;
                
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
