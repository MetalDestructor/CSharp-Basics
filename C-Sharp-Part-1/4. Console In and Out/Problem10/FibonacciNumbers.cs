using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class FibonacciNumbers
    {
        public static long Fibonacci(int n)
        {
            long a = 0;
			long b = 1;
			for(int i = 0; i<n; i++){
				long temp = a;
				a = b;
				b = a + temp;
			}
			return a;
        }
      
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
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