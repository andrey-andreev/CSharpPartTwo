using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07selectionSortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sorting an array means to arrange its elements in increasing order. 
            //Write a program to sort an array. Use the "selection sort" algorithm: Find 
            //the smallest element, move it at the first position, find 
            //the smallest from the rest, move it at the second position, etc.

            //enter the length of the array
            Console.WriteLine("Enter the length of the array:");
            int n = int.Parse(Console.ReadLine());

            //initialize and declare the array
            int[] arr = new int[n];
            Console.WriteLine("Enter the array's elements:");
            for (int index = 0; index < n; index++)
            {
                arr[index] = int.Parse(Console.ReadLine());
            }

            //sort algorithm
            for (int numIndex = 0; numIndex < n; numIndex++)
            {
                int min = int.MaxValue;
                int minIdex = 0;

                for (int compareNumIndex = numIndex; compareNumIndex < n; compareNumIndex++)
                {
                    if (min > arr[compareNumIndex])
                    {
                        min = arr[compareNumIndex];
                        minIdex = compareNumIndex;
                    }
                }
                arr[minIdex] = arr[numIndex];
                arr[numIndex] = min;
            }
            //print the sorted array
            Console.Write("This the sorted array:");
            for (int index = 0; index < arr.Length; index++)
            {
                Console.Write(" {0}", arr[index]);
            }
            Console.WriteLine();


        }
    }
}
