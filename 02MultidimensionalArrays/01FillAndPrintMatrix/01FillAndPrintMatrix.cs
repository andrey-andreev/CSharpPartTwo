using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
 *   a) 1 5  9 13     b) 1 8  9 16   c) 7 11 14 16   d)* 1 12 11 10
 *      2 6 10 14        2 7 10 15      4  8 12 15       2 13 16  9
 *      3 7 11 15        3 6 11 14      2  5  9 13       3 14 15  8
 *      4 8 12 19        4 5 12 13      1  3  6 10       4  5  6  7
 */


namespace _01FillAndPrintMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data
            Console.Write("Please, enter N :");
            int n = int.Parse(Console.ReadLine());

            // problem A
            Console.WriteLine();
            Console.WriteLine("Problem A");
            int[,] myMatrixA = new int[n, n];
            int startNum = 1;
            for (int col = 0; col < myMatrixA.GetLength(1); col++)
            {
                FillDown(col, startNum, myMatrixA);
                startNum += n;
            }
            PrintMatrix(myMatrixA);

            //problem B
            Console.WriteLine();
            Console.WriteLine("Problem B");
            int[,] myMatrixB = new int[n, n];
            startNum = 1;
            for (int col = 0; col < myMatrixB.GetLength(1); col++)
            {
                if (col % 2 == 0)
                {
                    //if col is even, we fill it up
                    FillDown(col, startNum, myMatrixB);
                }
                else
                {
                    //if col is down, we fill it down
                    FillUp(col, startNum, myMatrixB);
                }
                startNum += n;
            }
            PrintMatrix(myMatrixB);

            //problem C
            Console.WriteLine();
            Console.WriteLine("Problem C");
            int[,] myMatrixC = new int[n, n];
            FillDiagonally(myMatrixC);
            PrintMatrix(myMatrixC);

        }

        static void FillDown(int col, int startNum, int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = startNum + row;
            }
        }

        static void FillUp(int col, int startNum, int[,] matrix)
        {
            for (int row = matrix.GetLength(1) - 1; row >= 0; row--)
            {
                matrix[row, col] = startNum + matrix.GetLength(1) - 1 - row;
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,5}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        static void FillDiagonally(int[,] matrix)
        {
            int count = 1;
            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                int rowPrint = row;
                int col = 0;
                while (rowPrint < matrix.GetLength(0))
                {
                    matrix[rowPrint,col] = count;
                    rowPrint++;
                    col++;
                    count++;
                }
            }
            for (int col = 1; col < matrix.GetLength(1); col++)
            {
                int colPrint = col;
                int row = 0;
                while (colPrint < matrix.GetLength(1))
                {
                    matrix[row, colPrint] = count;
                    colPrint++;
                    row++;
                    count++;
                }
            }
            
        }
    }
}
