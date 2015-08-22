using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            Console.Write("Company name: ");
            string name = Console.ReadLine();
            Console.Write("Company address: ");
            string address = Console.ReadLine();
            Console.Write("Phone number: ");
            string pNumber = Console.ReadLine();
            Console.Write("Fax number: ");
            string fNumber = Console.ReadLine();
            Console.Write("Web site: ");
            string site = Console.ReadLine();
            Console.Write("Manager First Name: ");
            string fName = Console.ReadLine();
            Console.Write("Manager Last Name: ");
            string lName = Console.ReadLine();
            Console.Write("Manager Age: ");
            byte age = byte.Parse(Console.ReadLine());
            Console.Write("Manager Phone");
            string phone = Console.ReadLine();

            Console.WriteLine($"{name}");
            Console.WriteLine($"Adress: {address}");
            Console.WriteLine($"Tel. {pNumber}");
            Console.WriteLine($"Fax: {fNumber}");
            Console.WriteLine($"Web site: {site}");
            Console.WriteLine($"Manager: {fName} {lName} (age: {age}, tel. {phone})");
        }
    }
}
