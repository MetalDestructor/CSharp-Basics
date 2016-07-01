using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem16
{
    class RemoveElementsFromArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            var arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            var sizes = new int[n];
            for (int i = 0; i < n; i++)
            {
                sizes[i] = 1;
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] <= arr[i] && sizes[j] + 1 > sizes[i])
                    {
                        sizes[i] = sizes[j] + 1;
                    }
                }
            }
            Console.WriteLine(n - sizes.Max());
        }
    }
}
