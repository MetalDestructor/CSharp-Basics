using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("Your current Age : ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Your current age is : " + age);
        Console.WriteLine("After 10 years you will be : " + (age+10));
    }
}