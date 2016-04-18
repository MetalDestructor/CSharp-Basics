using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class FibonacciNumbers
    {
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = b + temp;
            }
            return a;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
			if(num == 1){
				Console.WriteLine("0");
				return;
			}
            for (int i = 0; i < num; i++)
            {
				if(i == num-1){
					Console.WriteLine("{0}", Fibonacci(i));
					break;
				}
                Console.Write("{0}, ", Fibonacci(i));
				
            }
        }
    }
}
