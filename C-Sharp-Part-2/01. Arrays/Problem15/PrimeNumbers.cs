using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool[] nums = Enumerable.Repeat(true, n + 1).ToArray();
            nums[0] = nums[1] = false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (nums[i])
                {
                    for (int j = i * i, add = 1; j < n + 1; j += add * i)
                    {
                        nums[j] = false;
                    }
                }
            }
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i])
                {
                    Console.WriteLine(i);
                    break;
                }
            }

        }
    }
}
