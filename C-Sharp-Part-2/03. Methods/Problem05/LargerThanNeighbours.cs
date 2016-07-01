using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    class LargerThanNeighbours
    {
        static int find(int[] nums)
        {
            int cnt = 0;
            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (nums[i-1] < nums[i] && nums[i+1] < nums[i])
                {
                    ++cnt;
                }
            }
            return cnt;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            Console.WriteLine(find(nums));
        }
    }
}
