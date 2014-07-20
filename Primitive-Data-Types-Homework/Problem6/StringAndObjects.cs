using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class StringAndObjects
    {
        static void Main(string[] args)
        {
            string first = "Hello";
            string second = "World";

            object concatenation = first + " " + second;

            string helloWorld = concatenation.ToString();

            Console.WriteLine(helloWorld);    
        }
    }
}
