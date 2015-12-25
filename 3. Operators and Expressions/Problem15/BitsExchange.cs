using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            int p1 = 3;
            int p2 = 4;
            int p3 = 5;
            int p4 = 24;
            int p5 = 25;
            int p6 = 26;

            int mask1 = 1 << p1;
            int mask3 = 1 << p2;
            int mask5 = 1 << p3;
            int numAndMask1 = num & mask1;
            int v1 = numAndMask1 >> p1;            
            if (v1 == 1)
            {
                int mask2 = v1 << p4;
                int result1 = num | mask2;
                int resultAndMask1 = result1 & mask3;
                int v2 = resultAndMask1 >> p2;
                if(v2 ==1)
                {
                    int mask4 = v2 << p5;
                    int result2 = num | mask4;
                    int resultAndMask2 = result2 & mask5;
                    int v3 = resultAndMask2 >> p3;
                    if (v3 ==1)
                    {
                        int mask6 = v3 << p6;
                        int result3 = num | mask6;
                        Console.WriteLine(result3);
                    }
                    else
                    {
                        int mask6 = ~(v3 << p6);
                        int result3 = num & mask6;
                        Console.WriteLine(result3);
                    }
                }
                else
                {
                    int mask4 = ~(v2 << p5);
                    int result2 = num & mask4;
                    int resultAndMask2 = result2 & mask5;
                    int v3 = resultAndMask2 >> p3;
                    if (v3 == 1)
                    {
                        int mask6 = v3 << p6;
                        int result3 = num | mask6;
                        Console.WriteLine(result3);
                    }
                    else
                    {
                        int mask6 = ~(v3 << p6);
                        int result3 = num & mask6;
                        Console.WriteLine(result3);
                    }
                }
            }
            else
            {
                int mask2 = ~(v1 << p4);
                int result1 = num & mask2;
                int resultAndMask1 = result1 & mask3;
                int v2 = resultAndMask1 >> p2;
                if (v2 == 1)
                {
                    int mask4 = v2 << p5;
                    int result2 = num | mask4;
                    int resultAndMask2 = result2 & mask5;
                    int v3 = resultAndMask2 >> p3;
                    if (v3 == 1)
                    {
                        int mask6 = v3 << p6;
                        int result3 = num | mask6;
                        Console.WriteLine(result3);
                    }
                    else
                    {
                        int mask6 = ~(v3 << p6);
                        int result3 = num & mask6;
                        Console.WriteLine(result3);
                    }
                }
                else
                {
                    int mask4 = ~(v2 << p5);
                    int result2 = num & mask4;
                    int resultAndMask2 = result2 & mask5;
                    int v3 = resultAndMask2 >> p3;
                    if (v3 == 1)
                    {
                        int mask6 = v3 << p6;
                        int result3 = num | mask6;
                        Console.WriteLine(result3);
                    }
                    else
                    {
                        int mask6 = ~(v3 << p6);
                        int result3 = num & mask6;
                        Console.WriteLine(result3);
                    }
                }
            }
        }
    }
}