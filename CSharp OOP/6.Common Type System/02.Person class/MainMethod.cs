using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Person_class
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            Person ivan = new Person("Ivan", 20);
            Person georgi = new Person("Georgi", null);

            Console.WriteLine(ivan);
            Console.WriteLine(georgi);
        }
    }
}
