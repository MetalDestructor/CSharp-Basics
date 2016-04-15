using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class PrintDeckOfCards
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 15; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    switch (i)
                    {
                        case 11:
                            Console.WriteLine("J ");
                            switch (j)
                            {
                                case 0:
                                    Console.WriteLine("of spades, ");
                                    break;
                                case 1:
                                    Console.WriteLine("of clubs, ");
                                    break;
                                case 2:
                                    Console.WriteLine("of hearts, ");
                                    break;
                                case 3:
                                    Console.WriteLine("of diamonds");
                                    break;
                            }
                            break;
                        case 12:
                            Console.WriteLine("Q ");
                            switch (j)
                            {
                                case 0:
                                    Console.WriteLine("of spades, ");
                                    break;
                                case 1:
                                    Console.WriteLine("of clubs, ");
                                    break;
                                case 2:
                                    Console.WriteLine("of hearts, ");
                                    break;
                                case 3:
                                    Console.WriteLine("of diamonds");
                                    break;
                            }
                            break;
                        case 13:
                            Console.WriteLine("K ");
                            switch (j)
                            {
                                case 0:
                                    Console.WriteLine("of spades, ");
                                    break;
                                case 1:
                                    Console.WriteLine("of clubs, ");
                                    break;
                                case 2:
                                    Console.WriteLine("of hearts, ");
                                    break;
                                case 3:
                                    Console.WriteLine("of diamonds");
                                    break;
                            }
                            break;
                        case 14:
                            Console.WriteLine("A ");
                            switch (j)
                            {
                                case 0:
                                    Console.WriteLine("of spades, ");
                                    break;
                                case 1:
                                    Console.WriteLine("of clubs, ");
                                    break;
                                case 2:
                                    Console.WriteLine("of hearts, ");
                                    break;
                                case 3:
                                    Console.WriteLine("of diamonds");
                                    break;
                            }
                            break;
                        default:
                            switch (j)
                            {
                                case 0:
                                    Console.WriteLine(i + " of spades, ");
                                    break;
                                case 1:
                                    Console.WriteLine(i + " of clubs, ");
                                    break;
                                case 2:
                                    Console.WriteLine(i + " of hearts, ");
                                    break;
                                case 3:
                                    Console.WriteLine(i + " of diamonds");
                                    break;
                            }
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
