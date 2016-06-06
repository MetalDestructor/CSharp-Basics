using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem07
{
    class OneSystemToAnyOther
    {
        static long ConvertToDec(string num, int s)
        {
            int[] numInt = new int[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                switch (num[i])
                {
                    case 'a': numInt[i] = 10; break;
                    case 'b': numInt[i] = 11; break;
                    case 'c': numInt[i] = 12; break;
                    case 'd': numInt[i] = 13; break;
                    case 'e': numInt[i] = 14; break;
                    case 'f': numInt[i] = 15; break;
                    default:
                        numInt[i] = num[i] - '0';
                        break;
                }
            }
            long num10 = 0;
            int power = 0;
            for (int i = numInt.Length - 1; i >= 0; i--)
            {
                num10 += numInt[i] * (long)Math.Pow(s, power);
                power++;
            }
            return num10;
        }
        static string ConvertToD(long num, int d)
        {
            StringBuilder numDsb = new StringBuilder();
            while(num > 0) {
                long digit = num % d;
                switch (digit)
                {
                    case 10: numDsb.Insert(0, 'A'); break;
                    case 11: numDsb.Insert(0, 'B'); break;
                    case 12: numDsb.Insert(0, 'C'); break;
                    case 13: numDsb.Insert(0, 'D'); break;
                    case 14: numDsb.Insert(0, 'E'); break;
                    case 15: numDsb.Insert(0, 'F'); break;

                    default:
                        numDsb.Insert(0, digit);
                        break;
                }
                
                num /= d;
            }
            return numDsb.ToString();

        }
        static string ConvertNumFromSToD(string num, int s, int d)
        {
            long dec = ConvertToDec(num, s);
            string numD = ConvertToD(dec, d);
            return numD;
        }
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            string num = Console.ReadLine().ToLower();
            int d = int.Parse(Console.ReadLine());
            string result = ConvertNumFromSToD(num, s, d);
            Console.WriteLine(result);
        }
    }
}
