using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                int ix = Array.IndexOf(alphabet, word[i]);
                Console.WriteLine(ix);
            }
        }
    }
}
