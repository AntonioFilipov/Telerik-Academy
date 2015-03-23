//Using delegates write a class Timer that can execute certain method at each t seconds.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _07.Timer
{
    class MainMethod
    {
        private static void SayBau()
        {
            Console.WriteLine("Bau");
        }


        static void Main(string[] args)
        {
            var testTimer = new Timer(1, SayBau);
            testTimer.Execute(50);
        }

    }

	
        
    
}
