using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School_classes
{
    public interface IComment
    {
        void Comment(string text);
        string Comment { get; }
    }
}
