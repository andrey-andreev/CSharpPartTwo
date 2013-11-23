using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08findsTheSequenceOfMaximalSumKadanesAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
             * Write a program that finds the sequence of maximal sum in given array. Example:
             * {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4} 
             * Can you do it with only one loop (with single scan through the elements of the array)?
            */

            // input the array's length
            Console.WriteLine("Enter the array's length:");
            int size = int.Parse(Console.ReadLine());

            //initialize and declare the array
            int[] arr = new int[size];
            Console.WriteLine("Enter the array's elements:");
            for (int index = 0; index < arr.Length; index++)
            {
                arr[index] = int.Parse(Console.ReadLine());
            }

            //declare variables 
            int startI = 0; //the index that mark the start of the sequence
            int endI = 0; //the index that mark the end of the sequence
            int maxTemp = 0;
            int maxSumSoFar = 0;

            //algorithm 
            for (int index = 0; index < arr.Length; index++)
            {
                if (maxTemp < 0)
                {
                    maxTemp = arr[index];
                    startI = index;
                }
                else
                {
                    maxTemp += arr[index];
                }
                if (maxTemp > maxSumSoFar)
                {
                    maxSumSoFar = maxTemp;
                    endI = index;
                }            
            }

            //print the result
            Console.Write("The sequence of max sum is {");
            for (int resultI = startI; resultI < endI + 1; resultI++)
            {
                Console.Write("{0}", arr[resultI]);
                if (resultI < endI)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("}");



        }
    }
}
