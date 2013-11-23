using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10findSequenceOfSum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a program that finds in given array of integers a sequence of given 
             * sum S (if present). Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11 ? {4, 2, 5}
             */

            //input the length of the array and the wanted sum
            Console.WriteLine("Enter the legth of the array:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the wanted sum:");
            int wSum = int.Parse(Console.ReadLine());

            //initialize and declare the array
            Console.WriteLine("Enter the array's elements:");
            int[] arr = new int[size];
            for (int index = 0; index < arr.Length; index++)
            {
                arr[index] = int.Parse(Console.ReadLine());
            }

            //ALGORITHM
            int startI = 0; //the index that mark the start of the sequence
            int endI = 0; //the index that mark the end of the sequence
            int maxSumSoFar = 0; 
            bool seqExist = false; // flag which mark the sequence existence
            for (int index = 0; index < arr.Length; index++)
            {
                // adding the current element to the temporary sum
                maxSumSoFar += arr[index];
                // check whether the temp max sum is smaller than the wanted sum
                if (maxSumSoFar < wSum) 
                {
                    endI = index;
                }
                // check whether the temp max sum is bigger than the wanted sum
                else if (maxSumSoFar > wSum) 
                {
                    // this loop subtract until temp max sum is lower or equal to the wanted sum
                    while (maxSumSoFar > wSum) 
                    {
                        maxSumSoFar -= arr[startI];
                        startI += 1;
                        if (maxSumSoFar == wSum)
                        {
                            seqExist = true;
                            break;
                        }
                    }
                }
                // when the temp max sum is equal to the wanted sum the loop breaks
                if (maxSumSoFar == wSum)
                {
                    endI = index;
                    seqExist = true;
                    break;
                }
            }

            //print the result 
            if (seqExist)
            {
                Console.Write("The sequence of given sum is {");
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
            else
            {
                Console.WriteLine("There is no such sequence of the given sum.");
            }

        }
    }
}
