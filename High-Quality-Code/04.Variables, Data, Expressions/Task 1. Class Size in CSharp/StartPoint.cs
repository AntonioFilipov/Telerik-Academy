using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Class_Size_in_CSharp
{
    class StartPoint
    {
        static void Main(string[] args)
        {
            Figure firstFigure = new Figure(5, 10.1);
            Figure rotatedFirstFigure = firstFigure.GetRotatedFigure(56.4);
        }
    }
}
