using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class FillTheMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            int[,] arr = new int[n, n];


            switch (c)
            {
                case 'a': FillA(arr); break;
                case 'b': FillB(arr); break;
                case 'c': FillC(arr); break;
                case 'd': FillD(arr); break;
                default:
                    break;
            }

            PrintArr(arr);
        }

        static void PrintArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (j == arr.GetLength(1) - 1)
                    {
                        Console.Write("{0}", arr[i, j]);
                    }
                    else
                    {
                        Console.Write("{0} ", arr[i, j]);
                    }

                }
                Console.WriteLine();
            }
        }

        static void FillA(int[,] arr)
        {
            int k = 1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[j, i] = k++;
                }
            }
        }

        static void FillB(int[,] arr)
        {
            int k = 1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[j, i] = k++;
                    }
                }
                else
                {
                    for (int j = arr.GetLength(1) - 1; j >= 0; j--)
                    {
                        arr[j, i] = k++;
                    }
                }

            }

        }

        static void FillC(int[,] arr)
        {
            //int t = 0;
            //int k = 1;
            //for (int i = arr.GetLength(0) - 1; i >= 0; i--)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {

            //        if ((j + t) < arr.GetLength(0))
            //        {
            //            arr[i, j + t] = k++;
            //            t++;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //    t = 0;
            //}
            int n = arr.GetLength(0);
            int num = 1;
            int firstHalf = arr.GetLength(0);
            int repeat = 1;
            for (int h = 0; h < firstHalf; h++)
            {
                int i = 0;
                int j = n - repeat;
                for (int k = 0; k < repeat; k++)
                {
                    arr[j, i] = num++;
                    i++;
                    j++;
                }
                repeat++;
            }

            repeat = n - 1;
            for (int h = 0; h < firstHalf - 1; h++)
            {
                for (int i = 0; i < repeat; i++)
                {
                    for (int j = n - repeat; j < n; j++)
                    {
                        arr[i, j] = num++;
                        i++;
                    }
                }
                repeat--;
            }
        }
        static void FillD(int[,] toFill)
        {
            return;
        }
    }
}

