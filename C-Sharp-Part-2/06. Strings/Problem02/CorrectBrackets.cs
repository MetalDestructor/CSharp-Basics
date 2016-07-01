using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            Stack<char> brackets = new Stack<char>();
            string expression = Console.ReadLine();
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    brackets.Push('(');
                }
                else if (expression[i] == ')')
                {
                    try
                    {
                        brackets.Pop();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Incorrect");
                        return;
                    }
                }
            }
            Console.WriteLine(brackets.Contains('(') ? "Incorrect" : "Correct");
        }
    }
}
