using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Define_class
{
    class StartingPoint
    {
        static void Main()
        {
            Console.WriteLine("================== TEST BATTERY CLASS ==============");
            GSMCallHistoryTest test1 = new GSMCallHistoryTest();
            test1.AddCallsToHistory();
            test1.DisplayCalls();
            test1.SetPricePerMinute(0.37m);
            test1.CalculateTotalPriceFromHistory();
            Console.WriteLine(String.Format("--------------Removing longest call--------------"));
            test1.RemoveTheLongestCall();
            test1.DisplayCalls();
            test1.CalculateTotalPriceFromHistory();
            Console.WriteLine(String.Format("--------------Clear history--------------"));
            test1.ClearAllHistory();
            test1.DisplayCalls();

            Console.WriteLine("================== TEST GSM CLASS ==============");
            GSMTest test2 = new GSMTest();
            test2.AddToList();
            test2.Display();
            test2.InfoStatic();
        }
    }
}
