using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that reads a rectangular matrix of size N x M and finds in it the 
 * square 3 x 3 that has maximal sum of its elements.
 */


namespace _02FindSubmatrixWithMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data
            Console.Write("Please, enter n (n > 3):");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please, enter m (m > 3):");
            int m = int.Parse(Console.ReadLine());

            //declare and initialize the matrix
            Console.WriteLine("Please, fill up the matrix:");
            int[,] matrix = new int[n, m];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("({0},{1})=", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            //test input data
            //int[,] matrix = 
            //{
            //    {1, 2,  1,  4,  6,  4},
            //    {2, 3,  9,  6,  4,  5},
            //    {4, 1,  1,  6,  1,  2},
            //    {3, 3,  3,  9,  1,  2},
            //    {3, 7,  4,  3,  4,  5}
            //};

            //print the matrix
            Console.WriteLine();
            Console.WriteLine("Your matrix is :");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,6}", matrix[row, col]);
                }
                Console.WriteLine();
            }



            //declare and initialize variables
            int maxSum = int.MinValue;
            int tempMaxSum = CalcTempMaxSum(0, 0, matrix);
            int rowIndexMax = 0;
            int colIndexMax = 0;

            //find the submatrix with maximal sum
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    tempMaxSum = CalcTempMaxSum(row,col,matrix);
                    if (tempMaxSum > maxSum)
                    {
                        maxSum = tempMaxSum;
                        rowIndexMax = row;
                        colIndexMax = col;
                    }
                    
                }
            }

            //print the result
            PrintSubMatrix(rowIndexMax, colIndexMax, matrix);
        }

        static int CalcTempMaxSum(int rowI, int colI, int[,] mat)
        {
            int sum = 0;
            for (int row = rowI; row < rowI + 3; row++)
            {
                for (int col = colI; col < colI + 3; col++)
                {
                    sum += mat[row, col];
                }
            }
            return sum;
        }

        static void PrintSubMatrix(int rowI, int colI, int[,] mat)
        {
            Console.WriteLine();
            Console.WriteLine("The sub matrix with maximal sum is :");
            for (int row = rowI; row < rowI + 3; row++)
            {
                for (int col = colI; col < colI + 3; col++)
                {
                    Console.Write("{0,6}", mat[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
