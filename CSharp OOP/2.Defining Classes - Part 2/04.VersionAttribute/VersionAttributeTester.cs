//Problem 11. Version attribute
//Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds a version in the format major.minor (e.g. 2.11).
//Apply the version attribute to a sample class and display its version at runtime.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[Version("1.0.0 Beta")]
class VersionAttributeTester
    {
        static void Main(string[] args)
        {
            object[] attributes = typeof(VersionAttributeTester).GetCustomAttributes(false);
		    Console.WriteLine("Version: {0}", attributes[0]);
        }
    }
