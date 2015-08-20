using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Method_PrintStatistics_in_CSharp
{
    class Printer
    {
        public static void PrintStatistics(double[] statistics, int count)
        {
            double maxValue = double.MinValue;
            double minValue = double.MaxValue;
            double sum = 0;

            for (int i = 0; i < count; i++)
            {
                double currentValue = statistics[i];

                if (maxValue < currentValue)
                {
                    maxValue = currentValue;
                }

                if (minValue > currentValue)
                {
                    minValue = currentValue;
                }

                sum += currentValue;
            }

            PrintNumber(maxValue);
            PrintNumber(minValue);

            double averageValue = sum / count;
            PrintNumber(averageValue);
        }

        public static void PrintNumber(double number)
        {
            Console.WriteLine(number);
        }
    }
}
