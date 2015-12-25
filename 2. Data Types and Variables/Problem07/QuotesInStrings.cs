using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class QuotesInStrings
    {
        static void Main(string[] args)
        {
            string firstTry = "The \"use\" of quotations causes difficulties";
            string secondTry = @"The ""use"" of quotations causes difficulties";

            Console.WriteLine("First way : " + firstTry);
            Console.WriteLine("Second way : " + secondTry);
        }
    }
}
