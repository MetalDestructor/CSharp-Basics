using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem08
{
    class NumberAsArray
    {
        static int[] sum(int[] arr1, int[] arr2, int length)
        {
            int[] res = new int[length];
            for (int i = 0; i < length; i++)
            {
                if (arr1.Length - 1 < i)
                {
                    if (arr2[i] > 9)
                    {
                        res[i] = arr2[i] % 10;
                        arr2[i + 1] += arr2[i] / 10;
                    }
                    else
                    {
                        res[i] = arr2[i];
                    }
                    continue;
                }
                if (arr2.Length - 1 < i)
                {
                    if (arr1[i] > 9)
                    {
                        res[i] = arr1[i] % 10;
                        arr1[i + 1] += arr1[i] / 10;
                    }
                    else
                    {
                        res[i] = arr1[i];
                    }
                    continue;
                }
                int t = arr1[i] + arr2[i];
                if (t > 9)
                {
                    res[i] = t % 10;
                    if (arr1.Length < arr2.Length)
                    {
                        if (i < length - 1)
                        {
                            ++arr2[i + 1];
                        }

                    }
                    else
                    {
                        if (i < length - 1)
                        {
                            ++arr1[i + 1];
                        }
                    }

                }
                else
                {
                    res[i] = t;
                }
            }
            return res;
        }
        static int[] sumArr(int[] arr1, int[] arr2)
        {
            int[] res;
            if (arr1.Length < arr2.Length)
            {
                res = sum(arr1, arr2, arr2.Length);
            }
            else
            {
                res = sum(arr1, arr2, arr1.Length);
            }
            return res;
        }

        static void Main(string[] args)
        {
            string rand = Console.ReadLine();
            int[] arr1 = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();





            foreach (var item in sumArr(arr1, arr2))
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
