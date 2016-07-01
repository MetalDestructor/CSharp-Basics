using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            string strNumber = numbers.ToString();

            int sum = int.Parse(strNumber[0].ToString()) 
                    + int.Parse(strNumber[1].ToString()) 
                    + int.Parse(strNumber[2].ToString()) 
                    + int.Parse(strNumber[3].ToString());
            Console.WriteLine(sum);

            char[] arrayNumbers = strNumber.ToCharArray();
            char swap = arrayNumbers[0];
            arrayNumbers[0] = arrayNumbers[3];
            arrayNumbers[3] = swap;
            swap = arrayNumbers[1];
            arrayNumbers[1] = arrayNumbers[2];
            arrayNumbers[2] = swap;
            Console.WriteLine(arrayNumbers);

            swap = arrayNumbers[1];
            arrayNumbers[1] = arrayNumbers[3];
            arrayNumbers[3] = swap;
            Console.WriteLine(arrayNumbers);

            swap = arrayNumbers[0];
            arrayNumbers[0] = arrayNumbers[1];
            arrayNumbers[1] = swap;
            swap = arrayNumbers[3];
            arrayNumbers[3] = arrayNumbers[1];
            arrayNumbers[1] = swap;
            Console.WriteLine(arrayNumbers);
        }
    }
}
