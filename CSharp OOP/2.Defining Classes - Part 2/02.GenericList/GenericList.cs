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
    class GenericList<T> where T : IComparable
    {
        //---Fields---//
        private int capacity = 0;
        private T[] array;
        private static int counter = -1;

        //---Properties---//
        public T[] Array
        {
            get { return this.array; }
            set { this.array = value; }
        }

        public int Capacity
        {
            get { return this.capacity; }
            set { this.capacity = value; }
        }

        //---Constructors---//
        public GenericList():this(0)
        {

        }
        public GenericList(int capacity)
        {
            this.Capacity = capacity;
            this.array = new T[Capacity];
        }

        //---Method for adding an element---//
        public void Add(T element)
        {
            GenericList<T>.counter++;
            if (this.Array.Length - 1 == GenericList<T>.counter)
            {
                this.Grow();
            }

            this.Array[counter] = element;
        }

        //---Method for accesing element by index---//
        public T AccessElementAtIndex(int index)
        {
            if (index < 0 || index >= this.Capacity - 1)
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }
            return this.Array[index];
        }

        //---Method for removing element by index---//
        public void RemoveElementAtIndex(int index)
        {
            if (index < 0 || index >= this.Capacity - 1)
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }

            while (index != this.Capacity-1)
            {
                this.Array[index] = this.Array[index + 1];
                index++;
            }
            this.Array[index] = default(T);
        }

        //---Method for inserting element at index---//
        public void InsetAtIndex(int index, T element)
        {
            if (GenericList<T>.counter == this.Capacity-1)
            {
                this.Grow();
            }

            T oldElement = this.Array[index];

            for (int i = counter; i > index; i--)
            {
                this.Array[i] = this.Array[i - 1];
            }
            this.Array[index] = element;
        }

        //---Method for clear the list of elements---//
        public void ClearList()
        {
            for (int i = 0; i < this.Array.Length; i++)
            {
                this.Array[i] = default(T);    
            }
        }

        //---Method for finding an element by value---//
        public T FindElementByValue(T value)
        {
            for (int i = 0; i < this.Array.Length; i++)
            {
                if (this.Array[i].Equals(value))
                {
                    return this.Array[i];
                }
            }
            throw new System.ArgumentException("Value not fount");
        }

        //---Override method ToString()---//
        public override string ToString()
        {
            return String.Join(", ", this.Array);
        }

        //---Method for extendig the list of elements---//
        public void Grow()
        {
            int growCapacity = this.Capacity*2;
            var growArray = new T[growCapacity];
            for (int i = 0; i < this.Capacity; i++)
            {
                growArray[i] = this.Array[i];
            }
            this.Capacity = growCapacity;
            this.Array = growArray;
        }

        //---Method for finding the min element---//
        public T Min()
        {
            T min = this.Array[0];

            for (int i = 0; i < counter; i++)
            {
                if (this.Array[i].CompareTo(min) < 0)
                {
                    min = this.Array[i];
                }
            }
            return min;
        }

        //---Method for finding the max element---//
        public T Max()
        {
            T max = this.Array[0];

            for (int i = 0; i < counter; i++)
            {
                if (this.Array[i].CompareTo(max) > 0)
                {
                    max = this.Array[i];
                }
            }   
            return max;
        }
    }
}
