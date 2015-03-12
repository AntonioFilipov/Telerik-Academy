using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Define_class
{
    class Call
    {
        //------Fields------//
        private DateTime date;
        private TimeSpan time;
        private string dialledPhoneNumber;
        private TimeSpan duration;

        //--------Constructors--------//
        public Call(DateTime date, TimeSpan time, string dialledPhoneNumber): this(date, time, dialledPhoneNumber,new TimeSpan())
        {
        }

        public Call(DateTime date, TimeSpan time, string dialledPhoneNumber,TimeSpan duration)
        {
            this.Date = date;
            this.Time = time;
            this.DialledPhoneNumber = dialledPhoneNumber;
            this.Duration = duration;
        }

        //-----------Properties------------//
        public DateTime Date { get { return this.date; } set { this.date = value; } }
        public TimeSpan Time { get { return this.time; } set { this.time = value; } }
        public string DialledPhoneNumber { get { return this.dialledPhoneNumber; } 
                                           set 
                                           {
                                               if (string.IsNullOrEmpty(value))
                                               {
                                                   throw new ArgumentException("Phone number cannot be null or empty.");
                                               }
                                               this.dialledPhoneNumber = value;
                                           }
                                          }
        public TimeSpan Duration { get { return this.duration; } set { this.duration = value; } }

        //-------Override ToString()-------//
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(String.Format("Date: {0}.{1}.{2}", this.Date.Day, this.Date.Month, this.Date.Year));
            result.AppendLine(String.Format("Time: {0}", this.Time));
            result.AppendLine(String.Format("Phone number: {0}", this.DialledPhoneNumber));
            result.AppendLine(String.Format("Duration: {0}", this.Duration));
            return result.ToString();
        }


    }
}
