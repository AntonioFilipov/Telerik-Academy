using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Print_the_ASCII_Table
{
    class PrintASCIITable
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.ASCII;
            for (int i = 0; i < 256; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
