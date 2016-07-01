using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem08
{
    class SumIntegers
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int res = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                res += nums[i];
            }
            Console.WriteLine(res);
        }
    }
}
