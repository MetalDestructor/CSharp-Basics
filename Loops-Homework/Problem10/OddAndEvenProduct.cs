using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] sNums = line.Split();
            int[] nums = new int[sNums.Length];
            int oddProduct = 1;
            int еvenProduct = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(sNums[i]);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if ((nums[i] & 1) == 1)
                {
                    oddProduct *= nums[i];
                }
                else
                {
                    еvenProduct *= nums[i];
                }
            }
            if (oddProduct == еvenProduct)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = " + oddProduct);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = " + oddProduct);
                Console.WriteLine("even_product = " + еvenProduct);
            }
        }
    }
}
