using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15
{
    class HexadecimalToDecimal
    {
        static void Main(string[] args)
        {
            string hexNum = Console.ReadLine();
            long result = 0;
            int power = hexNum.Length - 1;
            int iNum = 0;
            foreach (char num in hexNum.ToCharArray())
            {
                switch (num)
                {
                    case 'A':
                        iNum = 10;
                        result += iNum * (long)Math.Pow(16, power);
                        --power;
                        break;

                    case 'B':
                        iNum = 11;
                        result += iNum * (long)Math.Pow(16, power);
                        --power;
                        break;

                    case 'C':
                        iNum = 12;
                        result += iNum * (long)Math.Pow(16, power);
                        --power;
                        break;

                    case 'D':
                        iNum = 13;
                        result += iNum * (long)Math.Pow(16, power);
                        --power;
                        break;

                    case 'E':
                        iNum = 14;
                        result += iNum * (long)Math.Pow(16, power);
                        --power;
                        break;
                    case 'F':
                        iNum = 15;
                        result += iNum * (long)Math.Pow(16, power);
                        --power;
                        break;

                    default:
                        iNum = (int)char.GetNumericValue(num);
                        result += iNum * (long)Math.Pow(16, power);
                        --power;
                        break;
                }

            }
            Console.WriteLine(result);
        }
    }
}
