using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14
{
    class QuickSort
    {
        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static int partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int pIndex = start;
            for (int i = start; i < end; i++)
            {
                if (arr[i] <= pivot)
                {
                    swap(ref arr[pIndex], ref arr[i]);
                    ++pIndex;
                }
            }
            swap(ref arr[pIndex], ref arr[end]);
            return pIndex;
        }

        static void quickSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int pIndex = partition(arr, start, end);
                quickSort(arr, start, pIndex - 1);
                quickSort(arr, pIndex + 1, end);
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            quickSort(nums, 0, nums.Length - 1);

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
