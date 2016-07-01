using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14
{
    class IntegerCalculations
    {
        static decimal min(decimal[] nums)
        {
            decimal min = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            return min;
        }

        static decimal max(decimal[] nums)
        {
            decimal max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            return max;
        }

        static decimal avg(decimal[] nums)
        {
            decimal avg = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                avg += nums[i];
            }
            avg /= nums.Length;
            return avg;
        }

        static decimal sum(decimal[] nums)
        {
            decimal sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }

        static decimal product(decimal[] nums)
        {
            decimal product = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                product *= nums[i];
            }
            return product;
        }

        static void result(decimal min, decimal max, decimal avg, decimal sum, decimal product)
        {
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine("{0:F2}", avg);
            Console.WriteLine(sum);
            Console.WriteLine(product);
        }

        static void Main(string[] args)
        {
            decimal[] nums = Console.ReadLine().Split(' ').Select(x => decimal.Parse(x)).ToArray();
            result(min(nums), max(nums), avg(nums), sum(nums), product(nums));
        }
    }
}
