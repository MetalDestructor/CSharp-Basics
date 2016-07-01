using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem09
{
    class FrequentNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int[] res = new int[2];
            
            for (int i = 0; i < n; i++)
            {
                int br = 0;
                for (int j = 0; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        br++;
                    }
                }
                if (res[1] < br)
                {
                    res[0] = arr[i];
                    res[1] = br;
                }
            }
            Console.WriteLine("{0} ({1} times)", res[0], res[1]);
        }
    }
}
