using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Events
{
    class CustomEvent : EventArgs
    {
        // PROPERTIES

        public string Message { get; set; }

        // CONSTRUCTORS

        public CustomEvent(string text)
        {
            Message = text;
        }

        // METHODS

        public override string ToString()
        {
            return Message;
        }
    }
}
