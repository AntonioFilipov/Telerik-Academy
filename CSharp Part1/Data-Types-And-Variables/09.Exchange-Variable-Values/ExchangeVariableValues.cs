using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Exchange_Variable_Values
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 8;
            Console.WriteLine("BEFORE:{0} {1}", a, b);
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("AFTER: {0} {1}", a, b);
        }
    }
}
