//TODO
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class SumOf5Numbers
    {
        static void Main(string[] args)
        {
			int n1 = int.Parse(Console.ReadLine());
			int n2 = int.Parse(Console.ReadLine());
			int n3 = int.Parse(Console.ReadLine());
			int n4 = int.Parse(Console.ReadLine());
			int n5 = int.Parse(Console.ReadLine());
			
            int sum = n1 + n2 + n3 + n4 + n5;
            Console.WriteLine(sum);
        }
    }
}
