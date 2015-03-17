//Problem 8. Matrix
//Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).

//Problem 9. Matrix indexer
//Implement an indexer this[row, col] to access the inner matrix cells.

//Problem 10. Matrix operations
//Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
//Throw an exception when the operation cannot be performed.
//Implement the true operator (check for non-zero elements).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Problems_8_11
{
    class MatrixTest
    {
        static void Main(string[] args)
        {
            var a = new Matrix<int>(3,3);
            int[,] firstIntMatrix = new int[,]{
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            int[,] secondIntMatrix = new int[,]{
                {9,84,11},
                {2,10,9},
                {22,22,1}
            };
            var b = new Matrix<int>(firstIntMatrix);
            var c = new Matrix<int>(secondIntMatrix);
            Console.WriteLine(b);
            Console.WriteLine(c);

            var sum = b + c;
            Console.WriteLine("Sum:\n{0}", sum);

            var subtraction = b - c;
            Console.WriteLine("Substraction:\n{0}",subtraction);

            var multiplication = b * c;
            Console.WriteLine("Multiplication:\n{0}", multiplication);

            if (c)
            {
                Console.WriteLine("{0} does not contain zero elements", c);
            }
            else
            {
                Console.WriteLine("{0} contains zero element",c);
            }


        }
    }
}
