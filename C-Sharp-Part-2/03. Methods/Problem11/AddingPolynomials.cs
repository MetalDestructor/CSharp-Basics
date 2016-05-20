using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    class AddingPolynomials
    {
        static double[] addPolinomals(double[] p1, double[] p2)
        {
            double[] result = new double[p1.Length];
            for (int i = 0; i < p1.Length; i++)
            {
                result[i] = p1[i] + p2[i];
            }
            return result;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] p1 = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();
            double[] p2 = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();

            foreach (var item in addPolinomals(p1, p2))
            {
                Console.Write("{0} ", item);
            }

        }
    }
}
