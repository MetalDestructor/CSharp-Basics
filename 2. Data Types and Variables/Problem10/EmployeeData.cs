using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Pesho";
            string lastName = "Geshov";
            byte age = 18;
            bool isMale = true;
            string personalIdNumber = "8306112507";
            int employeeNumber = 27560000;

            Console.WriteLine("First Name : " + firstName + "\nLast Name : " + lastName + "\nAge : " + age);
            Console.Write("Gender : ");
            if (isMale == true)
            {
                Console.WriteLine("Male");
            }
            else
            {
                Console.WriteLine("Female");
            }
            Console.WriteLine("Personal ID number : " + personalIdNumber + "\nUnique employee number : " + employeeNumber);
        }
    }
}
