using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            string firstName = "Pesho";
            string middleName = "Hasan";
            string lastName = "Geshov";
            decimal balance = 24.45m;
            string bankName = "Durty Socks Inc.";
            string IBAN = "GB82 WEST 1234 5678 9123 45";
            long firstCreditCard = 123456789123456123L;
            long secondCreditCard = 123456789123456456L;
            long thirdCreditCard = 123456789123456789L;

            Console.WriteLine("Account holder: {0} {1} {2}", firstName, middleName, lastName);
            Console.WriteLine("Account balance: {0} BGN", balance);
            Console.WriteLine("Bank: {0}", bankName); ;
            Console.WriteLine("IBAN: {0}", IBAN);
            Console.WriteLine("Credit cards numbers: 1. {0}; 2. {1}; 3. {2}", firstCreditCard, secondCreditCard, thirdCreditCard);
        }
    }
}
