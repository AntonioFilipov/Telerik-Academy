using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main(string[] args)
        {
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;
            int compare = DateTime.Compare(birthday, now);
            if (compare > 0)
            {
                Console.WriteLine("You are not born!");
            }
            else
            {

                TimeSpan result = now.Subtract(birthday);
                Console.WriteLine("You are {0} years old!",(int)result.TotalDays/365);
                Console.WriteLine("After 10 years you will be {0} years old", (int)result.TotalDays / 365 + 10);
            }
                 
        }
    }
}
