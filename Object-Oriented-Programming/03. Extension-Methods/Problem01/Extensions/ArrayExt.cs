using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.Extensions
{
    public static class ArrayExt
    {
        public static int[] DividebleBySevenAndThree(this int[] numbers)
        {
            var result = numbers
                .Where(x => x % 7 == 0 && x % 3 == 0)
                .ToArray();
            return result;
        }
    }
}
