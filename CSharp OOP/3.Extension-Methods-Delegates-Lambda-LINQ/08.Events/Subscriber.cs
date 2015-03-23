using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Events
{
    class Subscriber
    {
        // CONSTRUCTORS

        public Subscriber(Publisher publisher)
        {
            publisher.RaiseEventTest += HandleCustomEvent; // take an event from the publisher
        }

        // METHODS

        public void HandleCustomEvent(Object publisher, CustomEvent e)
        {
            Console.WriteLine("Handling custom event:\n{0}", e); // handle it by printing
        }
    }
}
