using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13
{
    class MergeSort
    {
        static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
        }
        static void mergeSort(int[] arr)
        {
            int n = arr.Length;
            if (n < 2)
            {
                return;
            }
            int mid = n / 2;
            int[] left = new int[mid];
            int[] right = new int[n - mid];
            for (int i = 0; i < mid; i++)
            {
                left[i] = arr[i];
            }
            for (int i = mid; i < n; i++)
            {
                right[i - mid] = arr[i];
            }
            mergeSort(left);
            mergeSort(right);
            merge(left, right, arr);
        }
        static void merge(int[] arr1, int[] arr2, int[] res)
        {
            int n = arr1.Length;
            int m = arr2.Length;

            int i = 0;
            int j = 0;
            int k = 0;

            while (i < n && j < m)
            {
                if (arr1[i] <= arr2[j])
                {
                    res[k] = arr1[i];
                    ++i;
                }
                else
                {
                    res[k] = arr2[j];
                    ++j;
                }
                ++k;
            }
            while (i < n)
            {
                res[k] = arr1[i];
                ++i;
                ++k;
            }
            while (j < m)
            {
                res[k] = arr2[j];
                ++j;
                ++k;
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
            int[] res = new int[n];

            for (int i = 0; i < n; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            mergeSort(num);

            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
        }

    }
}
