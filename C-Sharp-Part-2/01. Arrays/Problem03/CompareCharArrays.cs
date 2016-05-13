using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            char[] char1 = str1.ToCharArray();
            char[] char2 = str2.ToCharArray();

            int res = str1.CompareTo(str2);
            if (res == 0)
            {
                Console.WriteLine("=");
            }
            else if (res > 0)
            {
                Console.WriteLine(">");
            }
            else
            {
                Console.WriteLine("<");
            }

            //if (char1.Length < char2.Length)
            //{
            //    Console.WriteLine("<");
            //}
            //else if (char1.Length > char2.Length)
            //{
            //    Console.WriteLine(">");
            //}
            //else
            //{
            //    for (int i = 0; i < char1.Length; i++)
            //    {
            //        if (char1[i] < char2[i])
            //        {
            //            Console.WriteLine("<");
            //            return;
            //        }
            //        else if (char1[i] > char2[i])
            //        {
            //            Console.WriteLine(">");
            //            return;
            //        }
            //        else
            //        {
            //            continue;
            //        }
            //    }
            //    Console.WriteLine("=");
            //}

        }
    }
}
