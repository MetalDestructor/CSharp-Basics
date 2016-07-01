using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class AppearanceCount
    {
        static int app(int[] nums, int x)
        {
            int cnt = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == x)
                {
                    ++cnt;
                }
            }
            return cnt;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine().Split(' ').Select(e => int.Parse(e)).ToArray();
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(app(nums, x));
        }
    }
}
