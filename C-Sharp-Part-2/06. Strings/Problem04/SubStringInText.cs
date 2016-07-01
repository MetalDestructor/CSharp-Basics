using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class SubStringInText
    {
        static void Main(string[] args)
        {
            string sub = Console.ReadLine();
            string str = Console.ReadLine();
            int br = 0;
            bool res = false;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == sub[0])
                {
                    int sl = i + 1;
                    for (int j = 1; j < sub.Length; j++)
                    {
                        if (str[sl] != sub[j])
                        {
                            res = false;
                            break;
                        }
                        else
                        {
                            res = true;
                        }
                        sl++;
                    }
                    if (res)
                    {
                        br++;
                    }
                }
            }
            Console.WriteLine(br);
        }
    }
}
