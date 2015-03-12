using System;
using System.Text;
namespace _01.Define_class
{
    class Display
    {
        //------Fields------//
        private decimal size = 0;
        private int numberOfColors = 0;

        //--------Constructors--------//
        public Display(decimal size) : this(size,0)
        {
        }

        public Display(decimal size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        //-----------Properties------------//
        public decimal Size
        {
            get
            { return this.size; }
            set
            { 
                if (value == 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("Display size should be > 0 and <= 10");
                }
                else
                {
                    this.size = value; 
                }
                   
                
            }           
        }

        public int NumberOfColors
        {
            get
            { return this.numberOfColors; }
            set
            {
                try
                {
                    this.numberOfColors = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        //-------Override ToString()-------//
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(String.Format("Display size: {0}", this.size));
            result.AppendLine(String.Format("Display number of colors: {0}", this.numberOfColors));
            return result.ToString();
        }
    }
}
