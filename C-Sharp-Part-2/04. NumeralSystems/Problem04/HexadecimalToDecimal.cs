using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class HexadecimalToDecimal
    {
        static void Main(string[] args)
        {
            string num16 = Console.ReadLine().ToLower();
            int[] num16Int = new int[num16.Length];
            for (int i = 0; i < num16.Length; i++)
            {
                switch (num16[i])
                {
                    case 'a': num16Int[i] = 10; break;
                    case 'b': num16Int[i] = 11; break;
                    case 'c': num16Int[i] = 12; break;
                    case 'd': num16Int[i] = 13; break;
                    case 'e': num16Int[i] = 14; break;
                    case 'f': num16Int[i] = 15; break;
                    default:
                        num16Int[i] = num16[i] - '0';
                        break;
                }
            }
            BigInteger num10 = 0;
            int power = 0;
            for (int i = num16Int.Length -1; i >= 0; i--)
            {
                num10 += num16Int[i] * (BigInteger)Math.Pow(16, power);
                power++;
            }
            
            Console.WriteLine(num10);
        }
    }
}
