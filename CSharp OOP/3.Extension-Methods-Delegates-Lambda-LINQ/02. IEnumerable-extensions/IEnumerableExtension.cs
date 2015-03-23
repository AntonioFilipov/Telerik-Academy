using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IEnumerable_extensions
{
    public static class IEnumerableExtension
    {
        public static T Sum<T>(this IEnumerable<T> list)
        {
            T result = default(T);
            foreach (var item in list)
            {
                result += (dynamic)item;
            }
            return result;
        }

        public static T Product<T>(this IEnumerable<T> list)
        {
            dynamic result = 1;
            foreach (var item in list)
            {
                result *= item;
            }
            return result;
        }

        public static T Min<T>(this IEnumerable<T> list)
        {
            T min = default(T);
            foreach (var item in list)
            {
                if (item!=null)
                {
                    min = item;
                    break;
                }
            }

            foreach (var item in list)
            {
                if ((dynamic)item < min )
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> list)
        {
            T max = default(T);
            foreach (var item in list)
            {
                if (item != null)
                {
                    max = item;
                    break;
                }
            }
            foreach (var item in list)
            {
                if ((dynamic)item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        public static T Average<T>(this IEnumerable<T> list)
        {
            return (dynamic)list.Sum()/list.Count();
        }

    }
}
