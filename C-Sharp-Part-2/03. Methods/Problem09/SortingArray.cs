using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem09
{
    class SortingArray
    {
        static int[] sortArr(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            foreach (var item in sortArr(nums))
            {
                Console.Write("{0} ", item);
            }

        }
    }
}
