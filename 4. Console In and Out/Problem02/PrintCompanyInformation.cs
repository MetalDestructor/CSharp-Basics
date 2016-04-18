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
            string name = Console.ReadLine();
            string address = Console.ReadLine();
            string pNumber = Console.ReadLine();
            string fNumber = Console.ReadLine();
            string site = Console.ReadLine();
            string fName = Console.ReadLine();
            string lName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            string phone = Console.ReadLine();

            Console.WriteLine("{0}", name != ""?name:"(no name)");
            Console.WriteLine("Address: {0}", address != ""?address:"(no address)");
            Console.WriteLine("Tel. {0}", pNumber != ""?pNumber:"(no phone number)");
            Console.WriteLine("Fax: {0}", fNumber != ""?fNumber:"(no fax)");
            Console.WriteLine("Web site: {0}", site != ""?site:"(no site)");
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", fName != ""?fName:"(no first name)", lName != ""?lName:"(no last name)", age, phone != ""?phone:"(no phone)");
        }
    }
}
