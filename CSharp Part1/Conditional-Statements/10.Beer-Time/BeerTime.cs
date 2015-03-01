/*A beer time is after 1:00 PM and before 3:00 AM.
 * Write a program that enters a time in format “hh:mm tt” 
(an hour in range [01...12], a minute in range [00…59] and AM / PM designator)
and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed.
Note: You may need to learn how to parse dates and times.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class BeerTime
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
        //Console.WriteLine("Enter a time in format \"hh:mm tt\":");
        //string input = Console.ReadLine();
        string input = "04:00 PM";
        string format = "hh:mm tt";
        DateTime dateTime = new DateTime();
        try
        {
            dateTime = DateTime.ParseExact(input, format, CultureInfo.InvariantCulture);
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid time!");
        }

        DateTime startBeerTime = DateTime.Parse("1:00 PM");
        DateTime endBeerTime = DateTime.Parse("3:00 AM");

        string getTT = dateTime.ToString("tt");
        if (getTT == "PM")
        {
            if (((dateTime.Hour + 11) % 12) + 1 >= 1 && ((dateTime.Hour + 11) % 12) + 1 <= 12)
            {
                Console.WriteLine("beer time");
            }
            else
                Console.WriteLine("not beer time");
        }
        else if (getTT == "AM") 
        {
            if (dateTime.Hour >= 0 && dateTime.Hour <= 3)
            {
                Console.WriteLine("beer time");
            }
            else
                Console.WriteLine("not beer time");
        }
       
    }
}

