using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringBuilder_Substring
{
    public static class SubstringExtension
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            StringBuilder result = new StringBuilder();
            if (index < 0 || index+length > str.Length-1 )
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
            for (int i = index; i < index+length; i++)
            {
                result.Append(str[i]);
            }
            return result;
        }
    }
}
