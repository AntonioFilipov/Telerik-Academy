using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02.Gravitation_On_The_Moon
{
    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            CultureInfo en = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = en;
            Console.Write("Enter your kilos(with \".\" separetor):");
            double kilosOnEarth = double.Parse(Console.ReadLine());
            Console.WriteLine(kilosOnEarth*0.17);

        }
    }
}
