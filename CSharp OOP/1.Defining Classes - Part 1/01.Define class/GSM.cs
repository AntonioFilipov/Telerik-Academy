using System;
using System.Text;
using System.Collections.Generic;

namespace _01.Define_class
{
    class GSM
    {
        //------Fields------//
        private string model = null;
        private string manufacturer = null;
        private decimal price = 0;
        private string owner = null;
        private Battery batteryCharacteristics;
        private Display displayCharacteristics;
        public static GSM iPhone4S = new GSM("4S", "IPhone",1250,"Stoqn",new Battery("Apple",234,100),new Display(5,160000000));
        private List<Call> callHistory = new List<Call>();
        private decimal totalCallPrice = 0;
        private decimal pricePerMinute = 0.16m;
        public static int countObject = 0;


        //--------Constructors--------//
        public GSM(string model, string manufacturer)
            : this(model, manufacturer, 0)
        {
        }

        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer, price, null)
        {
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer, price, owner, null)
        {
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery)
            :this(model,manufacturer,price, owner, battery, null)
        {
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.BatteryCharacteristics = battery;
            this.DisplayCharacteristics = display;
        }

        //-----------Properties------------//
        public string Model { get{return this.model;} set {this.model = value;} }
        public string Manufacturer { get { return this.manufacturer; } set { this.manufacturer = value; } }
        public decimal Price { get { return this.price; } set { this.price = value; } }
        public string Owner { get { return this.owner; } set { this.owner = value; } }
        public Battery BatteryCharacteristics { get { return this.batteryCharacteristics; } set { this.batteryCharacteristics = value; } }
        public Display DisplayCharacteristics { get { return this.displayCharacteristics; } set { this.displayCharacteristics = value; } }
        public GSM IPhone4S { get { return GSM.iPhone4S; }}
        public List<Call> CallHistory { get { return this.callHistory; } set { this.callHistory = value; } }
        public decimal TotalCallPrice { get { return this.totalCallPrice; } set { this.totalCallPrice = value; } }
        public decimal PricePerMinute { get { return this.pricePerMinute; } set { this.pricePerMinute = value; } }

        //-------Override ToString()-------//
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(String.Format("Model: {0}",this.Model));
            result.AppendLine(String.Format("Manufacturer: {0}", this.Manufacturer));
            result.AppendLine(String.Format("Price: {0}", this.Price));
            result.AppendLine(String.Format("Owner: {0}", this.Owner));
            if (this.BatteryCharacteristics == null)
            {
                result.AppendLine(String.Format("Battery model:"));
                result.AppendLine(String.Format("Battery hours idle:"));
                result.AppendLine(String.Format("Battery hours talk:"));
            }
            else
            {
                result.AppendLine(String.Format("Battery model: {0}", this.BatteryCharacteristics.Model));
                result.AppendLine(String.Format("Battery hours idle: {0}", this.BatteryCharacteristics.HoursIdle));
                result.AppendLine(String.Format("Battery hours talk: {0}", this.BatteryCharacteristics.HoursTalk));
            }

            if (this.DisplayCharacteristics == null)
            {
                result.AppendLine(String.Format("Display size:"));
                result.AppendLine(String.Format("Display number of colors:"));
            }
            else
            {
                result.AppendLine(String.Format("Display size: {0}", this.DisplayCharacteristics.Size));
                result.AppendLine (String.Format("Display number of colors: {0}", this.DisplayCharacteristics.NumberOfColors));
            }
           
            return result.ToString();
        }

        //--------Method for add/delete/clear calls----------//
        public void AddCalls(Call currentCall)
        {
            this.CallHistory.Add(currentCall);
        }

        public void DeleteCall(Call callToDelete)
        {
            this.CallHistory.Remove(callToDelete);
        }

        public void ClearCalls()
        {
            this.CallHistory.Clear();
        }

        //--------Method for calculation the total price ---------//
        public void CalculateTotalPrice()
        {
            foreach (var item in this.CallHistory)
            {
                this.totalCallPrice += int.Parse((item.Duration.Minutes.ToString())) * this.PricePerMinute;
            }
        }
       
    }
}
