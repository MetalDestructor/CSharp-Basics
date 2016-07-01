using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            DateTime today = DateTime.Now;
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            int age = today.Year - birthday.Year;

            if (today < birthday.AddYears(age)) --age;
            
            Console.WriteLine("{0}\n{1}",age, age+10);
        }
    }
}
