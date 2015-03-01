using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Comparing_Floats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;
            double a = 5.00000005;
            double b = 5.00000001;
            double substraction = Math.Abs(a - b);
            bool result = substraction <= eps;
            Console.WriteLine("Equals?: {0}", result);
            
        }
    }
}
