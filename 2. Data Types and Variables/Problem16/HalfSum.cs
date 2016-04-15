using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem16
{
    class HalfSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum1 = 0;
            for(int i = 0;i < n;i++)
            {
                int element = int.Parse(Console.ReadLine());
                sum1 += element;
            }

            int sum2 = 0;
            for(int i = 0;i < n;i++)
            {
                int element = int.Parse(Console.ReadLine());
                sum2 += element;
            }

            int diff = 0;

            if (sum1 > sum2)
            {
                diff = sum1 - sum2;
            }
            else if(sum2 > sum1)
            {
                diff = sum2 - sum1;
            }

            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum=" + sum1);
            }
            else
            {
                Console.WriteLine("No, diff=" + diff);
            } 
        }
    }
}
