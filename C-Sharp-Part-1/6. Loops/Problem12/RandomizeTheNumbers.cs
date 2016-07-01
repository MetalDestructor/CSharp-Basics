using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12
{
    class RandomizeTheNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Random rand = new Random();
            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = rand.Next((n + 1) - 1) + 1;
                Console.Write(nums[i] + " ");
            }
        }
    }
}
