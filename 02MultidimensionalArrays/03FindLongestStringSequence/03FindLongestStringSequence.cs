using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of 
 * several neighbor elements located on the same line, column or diagonal. Write a program that 
 * finds the longest sequence of equal strings in the matrix. Example:
 * ha   fifi    ho  hi              s   qq  s
 * fo   ha      hi  xx              pp  pp  s
 * xxx  ho      ha  xx              pp  qq  s
 * result: ha, ha, ha               result: s, s, s 
 */

namespace _03FindLongestStringSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data
            Console.WriteLine("Please enter N:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter M:");
            int cols = int.Parse(Console.ReadLine());

            string[,] strMat = new string[rows, cols];
            Console.WriteLine("Please fill up the matrix:");
            for (int row = 0; row < strMat.GetLength(0); row++)
            {
                for (int col = 0; col < strMat.GetLength(1); col++)
                {
                    Console.Write("({0},{1})=  ", row, col);
                    strMat[row, col] = Console.ReadLine();
                }
                Console.WriteLine();
            }

            Console.WriteLine("Your matrix is :");
            for (int row = 0; row < strMat.GetLength(0); row++)
            {
                for (int col = 0; col < strMat.GetLength(1); col++)
                {
                    Console.Write(strMat[row, col] + "   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            ////input test data
            //string[,] strMat = new string[3, 4] 
            //{
            //{"ha", "hg", "hi", "xx"},
            //{"fo", "h0", "xx", "sx"},
            //{"hi", "xx", "hi", "xx"}
            //};

            //
            int bestLength = 0;
            string bestValue = string.Empty;

            for (int row = 0; row < strMat.GetLength(0); row++)
            {
                for (int col = 0; col < strMat.GetLength(1); col++)
                {
                    int[] intMat = new int[4];
                    intMat[0] = CountRight(row, col, strMat);
                    intMat[1] = CountDown(row, col, strMat);
                    intMat[2] = CountLeftDiagonally(row, col, strMat);
                    intMat[3] = CountRigthDiagonally(row, col, strMat);
                    Array.Sort(intMat);
                    if (bestLength < intMat[3])
                    {
                        bestLength = intMat[3];
                        bestValue = strMat[row, col];
                    }
                }
            }

            //print the result
            Console.Write("The longest sequence of equal strings in the matrix is : ");
            for (int i = 0; i < bestLength; i++)
            {
                Console.Write(bestValue + "  ");
            }
            Console.WriteLine();
        }

        

        static int CountRight(int row, int col, string[,] mat)
        {
            int count = 1;
            for (int i = col; i < mat.GetLength(1) - 1; i++)
            {
                if (mat[row, i] == mat[row, i + 1])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        }

        static int CountDown(int row, int col, string[,] mat)
        {
            int count = 1;
            for (int i = row; i < mat.GetLength(0) - 1; i++)
            {
                if (mat[i, col] == mat[i + 1, col])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        }

        static int CountRigthDiagonally(int row, int col, string[,] mat)
        {
            int count = 1;
            while (row < mat.GetLength(0) - 1 && col < mat.GetLength(1) - 1)
            {
                if (mat[row,col] == mat[row + 1, col + 1])
                {
                    count++;
                }
                else
                {
                    break;
                }
                row++;
                col++;
            }
            return count;
        }

        static int CountLeftDiagonally(int row, int col, string[,] mat)
        {
            int count = 1;
            while (row < mat.GetLength(0) - 1 && col > 0)
            {
                if (mat[row,col] == mat[row + 1, col - 1])
                {
                    count++;
                }
                else
                {
                    break;
                }
                row++;
                col--;
            }

            return count;
        }
    }
}
