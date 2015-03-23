using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Events
{
    class TestMethod
    {
        static void Main(string[] args)
        {
            var publisher = new Publisher();

            new Subscriber(publisher).HandleCustomEvent(publisher, new CustomEvent("I am a very meaningless event"));
        }
    }
}
