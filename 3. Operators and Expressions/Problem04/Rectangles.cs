using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the rectangle's width : ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter the rectangle's height : ");
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            double perimeter = (2 * width) + (2 * height);
            Console.WriteLine("Recangle's width is {0}, his height is {1}, his area is {2} and his perimeter is {3}"
                , width, height, area, perimeter);
        }
    }
}
