//Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors).
//Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
using System;
using System.Collections.Generic;
namespace _01.Define_class
{
    class GSMTest
    {
        List<GSM> array = new List<GSM>();
        public void AddToList()
        {
            array.Add(new GSM("A536", "Lenovo"));
            array.Add(new GSM("S5", "Samsung", 900));
            array.Add(new GSM("X2", "Lenovo", 1200, "Tonkata"));
            array.Add(new GSM("Xperia", "Sony Ericsson", 800, "Alex", new Battery("SN", 36, 18)));
            array.Add(new GSM("Xperia", "Sony Ericsson", 800, "Alex", new Battery("SN", 36, 18), new Display(5, 16000000)));
        }
       
        public void Display()
        {
             foreach (var item in array)
             {
                 GSM.countObject++;
                 Console.WriteLine("Constructor {0}",GSM.countObject);
                 Console.WriteLine("--------------");
                 Console.WriteLine(item.ToString());
                 Console.WriteLine();
             }
            Console.WriteLine();
        }

        public void InfoStatic()
        {
            Console.WriteLine("Static Field:");
            Console.WriteLine("-------------");
            Console.WriteLine(GSM.iPhone4S.ToString());
        }

    }
}

;
