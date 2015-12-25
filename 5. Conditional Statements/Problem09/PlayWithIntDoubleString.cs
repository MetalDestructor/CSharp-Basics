using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem09
{
    class PlayWithIntDoubleString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                    int intNum = int.Parse(Console.ReadLine());
                    intNum = intNum + 1;
                    Console.WriteLine(intNum);
                    break;
                case 2:
                    double doubleNum = double.Parse(Console.ReadLine());
                    doubleNum = doubleNum + 1;
                    Console.WriteLine(doubleNum);
                    break;
                case 3:
                    String str = Console.ReadLine();
                    str = str + '*';
                    Console.WriteLine(str);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
