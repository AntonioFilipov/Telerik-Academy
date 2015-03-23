using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Events
{
    class Publisher // the class to raise the event
    {
        // DELEGATES

        public delegate void MyEventHandler(Object publisher, CustomEvent e); // delegate for event handlers

        // EVENTS

        public event MyEventHandler RaiseEventTest; // declare an event from the delegate

        // METHODS

        public void Raise(CustomEvent e) // raise a specifitic custom event
        {
            MyEventHandler handler = RaiseEventTest; // assign a delegate with the event

            if (handler != null)
            {
                Console.WriteLine("Publishing an event.");
                handler(this, e); // raise it
            }
        }
    }
}
