using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.Extensions
{
    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            StringBuilder newSB = new StringBuilder();
            for (int i = index; i < length + index; i++)
            {
                newSB.Append(sb.ToString()[i]);
            }
            return newSB;
        }

        public static decimal Sum<T>(this IEnumerable<T> en)
        {
            var res = en.Select(x => Convert.ToDecimal(x)).Sum();
            return res;
        }
        public static decimal Product<T>(this IEnumerable<T> en)
        {
            var resArr = en.Select(x => Convert.ToDecimal(x));
            decimal res = 1;
            foreach (var item in resArr)
            {
                res *= item;
            }
            return res;
        }
        public static decimal Min<T>(this IEnumerable<T> en)
        {
            var res = en.Select(x => Convert.ToDecimal(x)).Min();
            return res;
        }
        public static decimal Max<T>(this IEnumerable<T> en)
        {
            var res = en.Select(x => Convert.ToDecimal(x)).Max();
            return res;
        }
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var item in collection)
            {
                action(item);
            }
            return collection;
        }
    }
}
