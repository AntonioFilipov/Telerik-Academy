using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.class123_in_C
{
    class VariablePrinter
    {
        public static void Main(string[] args)
        {
            var printer = new ConsolePrinter.BooleanPrinter();
            printer.Print(true);
        }
    }
}
