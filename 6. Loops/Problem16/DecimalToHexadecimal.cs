using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem16
{
    class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            string hexNum = "";
            while (num != 0)
            {
                int digit = (int)(num % 16);
                switch (digit)
                {
                    case 10:
                        hexNum += 'A';
                        break;
                    case 11:
                        hexNum += 'B';
                        break;
                    case 12:
                        hexNum += 'C';
                        break;
                    case 13:
                        hexNum += 'D';
                        break;
                    case 14:
                        hexNum += 'E';
                        break;
                    case 15:
                        hexNum += 'F';
                        break;
                    default:
                        hexNum += (num % 16);
                        break;
                }
                num = num / 16;
            }
            char[] rev = hexNum.ToCharArray();
            Array.Reverse(rev);
            string realHN = new string(rev);
            Console.WriteLine(realHN);
        }
    }
}
