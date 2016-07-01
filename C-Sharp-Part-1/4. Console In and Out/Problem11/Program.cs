using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    class Interval
    {
        static void Main(string[] args)
        {
            int cnt = 0;

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            for (int i = n1+1; i < n2; i++)
            {
                if (i%5 == 0)
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
