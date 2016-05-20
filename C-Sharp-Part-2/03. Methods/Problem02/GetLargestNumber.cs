using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class GetLargestNumber
    {
        static long getMax(long[] nums)
        {
            long max = nums[0];
            for (int i = 1; i < 3; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            long[] nums = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            Console.WriteLine(getMax(nums));

        }
    }
}
