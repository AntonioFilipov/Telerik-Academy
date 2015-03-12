using System;
using System.Text;
namespace _01.Define_class
{
    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }

    class Battery
    {
        //------Fields------//
        private string model = null;
        private int hoursIdle = 0;
        private int hoursTalk = 0;
        private BatteryType bateryTypeInfo;

        //--------Constructors--------//
        public Battery(string model) : this(model, 0)
        {
        }

        public Battery(string model, int hoursIdle) : this(model, hoursIdle,0)
        {
        }

        public Battery(string model, int hoursIdle, int hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        //-----------Properties------------//
        public string Model 
        {
            get
            { return this.model; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("No value!");
                }
                else if (value.Length == 0|| value.Length > 15)
                {
                    throw new ArgumentOutOfRangeException("Model name should be longer than 0 and shorter than 15 symbols");
                }
                this.model = value; }
        }

        public int HoursIdle
        {
            get
            { return this.hoursIdle; }
            set
            {
                try
                {	        
		        this.hoursIdle = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public int HoursTalk
        {
            get
            { return this.hoursTalk; }
            set
            {
                try
                {
                this.hoursTalk = value;
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
            result.AppendLine(String.Format("Battery model: {0}", this.Model));
            result.AppendLine(String.Format("Battery hours idle: {0}", this.HoursIdle));
            result.AppendLine(String.Format("Battery hours talk: {0}", this.HoursTalk));
            return result.ToString();
        }
    }
}   
