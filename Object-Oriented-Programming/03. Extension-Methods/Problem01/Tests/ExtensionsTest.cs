using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    using Extensions;
    public static class ExtensionsTest
    {
        public static void Test()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("asdAzsummnogogotinnaprawosdad");
            StringBuilder sb1 = sb.Substring(7, 10);
            Console.WriteLine(sb1.ToString());

            IEnumerable<int> someCollection = new List<int>() { 1, -6, 16, 8, 35 };
            Console.WriteLine(someCollection.Max());
            Console.WriteLine(someCollection.Min());
            Console.WriteLine(someCollection.Product());
            Console.WriteLine(someCollection.Sum());
            Console.WriteLine(someCollection.Average());
        }
    }
}
