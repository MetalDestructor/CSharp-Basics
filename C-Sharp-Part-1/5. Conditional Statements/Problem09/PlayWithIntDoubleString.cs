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
            string select = Console.ReadLine();
            switch (select)
            {
                case "integer":
                    int intNum = int.Parse(Console.ReadLine());
                    intNum = intNum + 1;
                    Console.WriteLine(intNum);
                    break;
                case "real":
                    double doubleNum = double.Parse(Console.ReadLine());
                    doubleNum = doubleNum + 1;
                    Console.WriteLine("{0:F2}", doubleNum);
                    break;
                case "text":
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
