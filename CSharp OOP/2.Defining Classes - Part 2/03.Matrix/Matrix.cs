//Problem 8. Matrix
//Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).

//Problem 9. Matrix indexer
//Implement an indexer this[row, col] to access the inner matrix cells.

//Problem 10. Matrix operations
//Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
//Throw an exception when the operation cannot be performed.
//Implement the true operator (check for non-zero elements).
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Problems_8_11
{
    class Matrix<T>
    {
        //-----Fields----//
        private T[,] matrix;
        private int row = 0;
        private int col = 0;

        //------Properties------//
        public int Col
        {
            get { return this.col; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Cols must be >= 0");
                }
                this.col = value;
            }
        }

        public int Row
        {
            get { return this.row; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Cols must be >= 0");
                }
                this.row = value;
            }
        }

        public T[,] Matrix1
        {
            get { return this.matrix; }
            set { this.matrix = value; }
        }

        //------Indexer-----//
        public T this[int row, int col]
        {
            get
            {
                if (row > this.Row - 1 || col > this.Col - 1 || row < 0 || col < 0)
                {
                    throw new IndexOutOfRangeException("Invalid index!");
                }
                return this.matrix[row, col];
            }
            set
            {
                
                this.matrix[row, col] = value;
            }
        }

        //------Constructors-----//
        public Matrix()
            : this(0, 0)
        {

        }

        public Matrix(int row, int col)
        {
            this.row = row;
            this.col = col;
            this.matrix = new T[row, col];
        }

        public Matrix(T[,] predifinedMatrix)
        {
            this.Matrix1 = predifinedMatrix;
            this.Row = predifinedMatrix.GetLength(0);
            this.Col = predifinedMatrix.GetLength(1);
        }

        //-----Override ToString()----//
        public override string ToString()
        {

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.Matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < this.Matrix1.GetLength(1); j++)
                {
                    result.AppendFormat("{0,5}",this.Matrix1[i,j]);
                }
                result.AppendLine();
               
            }
            return result.ToString();
        }

        //------Matrix operations------//
        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Col != m2.Col || m1.Row != m2.Row)
            {
                throw new ArgumentException("Matrices must have the same number of rows and the same number of columns");
            }
            Matrix<T> result = new Matrix<T>(m1.Row, m1.Col);
            for (int i = 0; i < m1.Row; i++)
            {
                for (int j = 0; j < m1.Col; j++)
                {
                    result[i, j] = (dynamic)m1[i, j] + (dynamic)m2[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Col != m2.Col || m1.Row != m2.Row)
            {
                throw new ArgumentException("Matrices must have the same number of rows and the same number of columns");
            }
            Matrix<T> result = new Matrix<T>(m1.Row, m1.Col);
            for (int i = 0; i < m1.Row; i++)
            {
                for (int j = 0; j < m1.Col; j++)
                {
                    result[i, j] = (dynamic)m1[i, j] - (dynamic)m2[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Col != m2.Col || m1.Row != m2.Row)
            {
                throw new ArgumentException("Matrices must have the same number of rows and the same number of columns");
            }
            Matrix<T> result = new Matrix<T>(m1.Row, m1.Col);
            for (int i = 0; i < m1.Row; i++)
            {
                for (int j = 0; j < m1.Col; j++)
                {
                    result[i, j] = (dynamic)m1[i, j] * (dynamic)m2[i, j];
                }
            }

            return result;
        }

        //--------Implement the true/false operator-------//
        public static bool operator true(Matrix<T> matrix)
        {
            bool nonZeroElements = true;

            for (int i = 0; i < matrix.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        nonZeroElements = false;
                    }
                }
            }

            return nonZeroElements;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            bool nonZeroElements = true;

            for (int i = 0; i < matrix.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        nonZeroElements = false;
                    }
                }
            }

            return nonZeroElements;
        }
    }
}
