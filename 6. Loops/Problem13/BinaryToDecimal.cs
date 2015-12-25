using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            string binaryNum = Console.ReadLine();
            long result = 0;
            int power = binaryNum.Length - 1;
            foreach (char num in binaryNum.ToCharArray())
            {
                int iNum = (int)char.GetNumericValue(num);
                result += iNum * (long)Math.Pow(2, power);
                --power;
            }
            Console.WriteLine(result);
        }
    }
}
