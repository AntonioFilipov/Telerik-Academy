using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Class_Size_in_CSharp
{
    class Figure
    {
        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
    
        public double Width { get; set; }

        public double Height { get; set; }

        public Figure GetRotatedFigure(double angle)
        {
            double absoluteCosineOfAngle = Math.Abs(Math.Cos(angle));
            double absoluteSineOfAngle = Math.Abs(Math.Sin(angle));

            double widthRotatedFigure = (absoluteCosineOfAngle * this.Width) + (absoluteSineOfAngle * this.Height);
            double heightRotatedFigure = (absoluteSineOfAngle * this.Width) + (absoluteCosineOfAngle * this.Height);

            Figure rotatedFigure = new Figure(widthRotatedFigure, heightRotatedFigure);
            return rotatedFigure;
        }
    }
}
