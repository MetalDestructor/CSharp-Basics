using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem08
{
    class BinaryShort
    {
        static void Main(string[] args)
        {
            short num = short.Parse(Console.ReadLine());
            string binary = ShortToBinary(num);
            Console.WriteLine("{0}{1}",binary[0] ,binary.Substring(1, 15));
        }
        static string ShortToBinary(short number)
        {
            byte[] bytesInput = BitConverter.GetBytes(number);
            string inputToBinary = "";
            for (int i = 0; i < bytesInput.Length; i++)
            {
                inputToBinary = Convert.ToString(bytesInput[i], 2).PadLeft(8, '0') + inputToBinary;
            }
            return inputToBinary;
        }
    }
}
