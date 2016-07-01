using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem03
{
    class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            long num10 = long.Parse(Console.ReadLine());
            string num16 = Convert.ToString(num10, 16);
            for (int i = 0; i < num16.Length; i++)
            {
                switch (num16[i])
                {
                    case 'a':
                        StringBuilder sb = new StringBuilder();
                        sb.Append(num16);
                        sb[i] = 'A';
                        num16 = sb.ToString();
                        sb.Remove(0, sb.Length);
                        break;
                    case 'b':
                        sb = new StringBuilder();
                        sb.Append(num16);
                        sb[i] = 'B';
                        num16 = sb.ToString(); break;
                    case 'c':
                        sb = new StringBuilder();
                        sb.Append(num16);
                        sb[i] = 'C';
                        num16 = sb.ToString(); break;
                    case 'd':
                        sb = new StringBuilder();
                        sb.Append(num16);
                        sb[i] = 'D';
                        num16 = sb.ToString(); break;
                    case 'e':
                        sb = new StringBuilder();
                        sb.Append(num16);
                        sb[i] = 'E';
                        num16 = sb.ToString(); break;
                    case 'f':
                        sb = new StringBuilder();
                        sb.Append(num16);
                        sb[i] = 'F';
                        num16 = sb.ToString(); break;

                    default:
                        break;
                }
            }

            Console.WriteLine(num16);

        }
    }
}
