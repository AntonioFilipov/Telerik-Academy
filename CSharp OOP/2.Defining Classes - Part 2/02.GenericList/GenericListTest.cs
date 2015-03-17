//Problem 5. Generic class
//Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
//Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
//Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString().
//Check all input parameters to avoid accessing elements at invalid positions.

//Problem 6. Auto-grow
//Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.

//Problem 7. Min and Max
//Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
//You may need to add a generic constraints for the type T.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Generic_class
{
    class GenericListTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================GenericList<string>===============");
            GenericList<string> listString = new GenericList<string>(5);
            Console.WriteLine("List Capacity:{0}",listString.Capacity);
            listString.Add("Toni");
            listString.Add("Moni");
            listString.Add("Boni");

            Console.WriteLine("Elements in List:{0}",listString.ToString());

            Console.WriteLine("Element at index {0}: {1}",2,listString.AccessElementAtIndex(2));

            Console.WriteLine("Remove element at index 1");
            listString.RemoveElementAtIndex(1);
            Console.WriteLine("Elements in List:{0}", listString.ToString());

            Console.WriteLine("Insert at index 1");
            listString.InsetAtIndex(1, "Niki");
            Console.WriteLine("Elements in List:{0}", listString.ToString());

            Console.WriteLine("FindElementByValue: {0}", listString.FindElementByValue("Niki"));
            Console.WriteLine("Elements in List:{0}", listString.ToString());

            Console.WriteLine("Min:{0}", listString.Min());

            Console.WriteLine("Max:{0}", listString.Max());

            Console.WriteLine("Clear List");
            listString.ClearList();
            Console.WriteLine("Elements in List:{0}", listString.ToString());



            Console.WriteLine("=================GenericList<int>===============");
            GenericList<int> listInt = new GenericList<int>(9);
            Console.WriteLine("List Capacity:{0}", listInt.Capacity);

            listInt.Add(6);
            listInt.Add(3);
            listInt.Add(4);
            Console.WriteLine("Elements in List:{0}", listInt.ToString());
            Console.WriteLine("Element at index {0}: {1}", 2, listInt.AccessElementAtIndex(2));

            Console.WriteLine("Remove element at index 1");
            listInt.RemoveElementAtIndex(1);
            Console.WriteLine("Elements in List:{0}", listInt.ToString());

            Console.WriteLine("Insert at index 1");
            listInt.InsetAtIndex(1, 1000);
            Console.WriteLine("Elements in List:{0}", listInt.ToString());

            Console.WriteLine("FindElementByValue: {0}",listInt.FindElementByValue(6));
            Console.WriteLine("Elements in List:{0}", listInt.ToString());

            Console.WriteLine("Min:{0}", listInt.Min());

            Console.WriteLine("Max:{0}", listInt.Max());

            Console.WriteLine("Clear List");
            listInt.ClearList();
            Console.WriteLine("Elements in List:{0}", listInt.ToString());


        }
    }
}
