//Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range.
//It should hold error message and a range definition [start … end].
//Write a sample application that demonstrates the InvalidRangeException<int> and 
//InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03.Range_Exceptions
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            int[] sampleNumbers = { 12, 234,532 };

            foreach (int number in sampleNumbers)
            {
                try
                {
                    if (number < 0 || number > 100)
                    {
                        throw new InvalidRangeException<int>(0, 100);
                    }
                    Console.WriteLine("{0} is in the allowed range", number);
                }
                catch (InvalidRangeException<int> ex)
                {
                    Console.WriteLine("{0} - {1}", number, ex.Message);
                }
            }

            Console.WriteLine();

            DateTime[] sampleDates = { new DateTime(1990, 5, 22), DateTime.Now };
            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31, 23, 59, 59);

            foreach (DateTime date in sampleDates)
            {
                try
                {
                    if (date < startDate || date > endDate)
                    {
                        throw new InvalidRangeException<DateTime>(startDate, endDate);
                    }
                    Console.WriteLine("{0:D} is in the allowed range", date);
                }
                catch (InvalidRangeException<DateTime> ex)
                {
                    Console.WriteLine("{0:D} - {1}", date, ex.Message);
                }
            }
        }
    }
}
