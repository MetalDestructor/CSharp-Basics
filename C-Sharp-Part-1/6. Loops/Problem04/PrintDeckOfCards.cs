using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class PrintDeckOfCards
    {
        public static void printPaints(char c)
        {
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", c);
        }
        static void Main(string[] args)
        {
            char n = (char)Console.Read();
            if (n >= '2' && n <= '9')
            {
                switch (n)
                {
                    case '3':
                        for (char i = '2'; i <= '3'; i++)
                        {
                            printPaints(i);
                        }; break;
                    case '4':
                        for (char i = '2'; i <= '4'; i++)
                        {
                            printPaints(i);
                        }; break;
                    case '5':
                        for (char i = '2'; i <= '5'; i++)
                        {
                            printPaints(i);
                        }; break;
                    case '6':
                        for (char i = '2'; i <= '6'; i++)
                        {
                            printPaints(i);
                        }; break;
                    case '7':
                        for (char i = '2'; i <= '7'; i++)
                        {
                            printPaints(i);
                        }; break;
                    case '8':
                        for (char i = '2'; i <= '8'; i++)
                        {
                            printPaints(i);
                        }; break;
                    case '9':
                        for (char i = '2'; i <= '9'; i++)
                        {
                            printPaints(i);
                        }; break;
                    default:
                        break;
                }

            }
            else if (n == 'J' || n == 'Q' || n == 'K' || n == 'A')
            {
                switch (n)
                {
                    case 'J':
                        for (char i = '2'; i <= '9'; i++)
                        {
                            printPaints(i);
                        };
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", 'J');
                        break;
                    case 'Q':
                        for (char i = '2'; i <= '9'; i++)
                        {
                            printPaints(i);
                        };
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", 'J');
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", 'Q');
                        break;
                    case 'K':
                        for (char i = '2'; i <= '9'; i++)
                        {
                            printPaints(i);
                        };
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", 'J');
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", 'Q');
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", 'K');
                        break;
                    case 'A':
                        for (char i = '2'; i <= '9'; i++)
                        {
                            printPaints(i);
                        };
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", 'J');
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", 'Q');
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", 'K');
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", 'A');
                        break;
                    default:
                        break;
                }
            }

        }
    }
}