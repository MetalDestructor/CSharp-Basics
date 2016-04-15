using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem18
{
    class NineDigitMagicNumber
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            int result = 0;

            for (int num1 = 111; num1 <= 777; num1++)
            {
                int num2 = num1 + diff;
                int num3 = num2 + diff;

                if (IsAvaliable(num1) && IsAvaliable(num2) && IsAvaliable(num3) && (num3 <= 777)
                    && CalcSum(num1) + CalcSum(num2) + CalcSum(num3) == sum)
                {
                    Console.WriteLine("{0}{1}{2}", num1, num2, num3);
                    result++;
                }
            }

            if (result == 0)
            {
                Console.WriteLine("No");
            } 
        }
        private static int CalcSum(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;
            }
            return sum;
        }
        private static bool IsAvaliable(int num)
        {
            string digits = num.ToString();
            foreach(var digit in digits)
            {
                if(digit < '1' || digit > '7')
                {
                    return false;
                }
            }
            return true;
        }    
    }
}
