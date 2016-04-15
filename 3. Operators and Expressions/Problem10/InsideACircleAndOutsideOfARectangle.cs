using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class InsideACircleAndOutsideOfARectangle
    {
        static void Main(string[] args)
        {
            double x = Double.Parse(Console.ReadLine());
            double y = Double.Parse(Console.ReadLine());
			bool isInCircle = Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2) <= Math.Pow(1.5, 2);
			bool isInRectangle = ((x >= -1) && (x <= 5) && (y <= 1) && (y >= -1));
            if (isInCircle)
            {
                if (isInRectangle)
				{
					Console.WriteLine("inside circle inside rectangle");
				}
				else
				{
					Console.WriteLine("inside circle outside rectangle");
				}
            }
            else
            {
				if (isInRectangle)
				{
					Console.WriteLine("outside circle inside rectangle");
				}
				else
				{
					Console.WriteLine("outside circle outside rectangle");
				}
            }
        }
    }
}