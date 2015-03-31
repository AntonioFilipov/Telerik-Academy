using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Range_Exceptions
{
    class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        public InvalidRangeException(T start, T end)
        {
            this.start = start;
            this.end = end;
        }

        public override string Message
        {
            get
            {
                return string.Format("{0} is out of the allowed range [{1}, {2}]",
                    typeof (T).Name, this.Start, this.End);
            }
        }



        public T Start 
        {
            get { return this.start; }
        }

        public T End
        {
            get { return this.end; }
        }
        
    }
}
