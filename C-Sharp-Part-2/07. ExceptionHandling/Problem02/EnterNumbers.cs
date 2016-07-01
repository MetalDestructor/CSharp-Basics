using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class EnterNumbers
    {
        static void ReadNumber(int start, int end, int[] nums)
        {
            if (nums[start - 1] <= 1)
            {
                throw new Exception();
            }
            else if (nums[9] >= 100)
            {
                throw new Exception();
            }
            for (int i = start; i < 10; i++)
            {
                if (nums[i - 1] >= nums[i])
                {
                    throw new Exception();
                }

            }
            for (int i = 0; i < 10; i++)
            {
                if (i == 9)
                {
                    Console.WriteLine("{0} < 100", nums[i]);
                }
                else if (i == 0)
                {
                    Console.Write("1 < {0} < ", nums[i]);
                }
                else
                {
                    Console.Write("{0} < ", nums[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            for (int i = 0; i < 10; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            try
            {
                ReadNumber(1, 100, nums);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
        }
    }
}
