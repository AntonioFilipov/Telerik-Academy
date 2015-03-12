using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Define_class
{
    class GSMCallHistoryTest
    {
        GSM gsm1 = new GSM("Xperia", "Sony Ericsson", 800, "Alex", new Battery("SN", 36, 18), new Display(5, 16000000));

        Call lastCall1 = new Call(new DateTime(2012, 12, 1), new TimeSpan(10, 20, 0), "0898787432421", new TimeSpan(0, 22, 9));
        Call lastCall2 = new Call(new DateTime(2014, 1, 2), new TimeSpan(10, 20, 0), "0898787432421", new TimeSpan(0, 32, 9));
        
        public void SetPricePerMinute(decimal price)
        {
            gsm1.PricePerMinute = price;
        }
        
        public void AddCallsToHistory()
        {
            gsm1.AddCalls(lastCall1);
            gsm1.AddCalls(lastCall2);
        }

        public void DisplayCalls()
        {
            
            foreach (var item in gsm1.CallHistory)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void CalculateTotalPriceFromHistory()
        {
            gsm1.TotalCallPrice = 0;
            gsm1.CalculateTotalPrice();
            Console.WriteLine("Price: {0}",gsm1.TotalCallPrice);          
        }

        public void RemoveTheLongestCall()
        {
            Call longestCall = lastCall1;
            foreach (var item in gsm1.CallHistory)
            {
                if (int.Parse(item.Duration.Minutes.ToString()) > int.Parse(longestCall.Duration.Minutes.ToString()))
                {
                    longestCall = item;
                }
            }

            gsm1.DeleteCall(longestCall);
        }

        public void ClearAllHistory()
        {
            gsm1.ClearCalls();
        }
        
    }
}
