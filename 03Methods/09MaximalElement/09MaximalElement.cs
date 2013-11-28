using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Write a method that return the maximal element in a portion of array of integers 
 * starting at given index. Using it write another method that sorts an array in 
 * ascending / descending order.
 */

namespace _09MaximalElement
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[] { 1, -59, 12, 123, -56, 76, 111, 45, 101, -35 };
            Console.WriteLine("Array:");
            PrintArray(0, arr);
            int startElement = 2;
            Console.WriteLine("The start element is {0}.\n", startElement);
            //find the maximal element in a portion of array
            Console.WriteLine("Maximal element:");
            int maxI = FindMinOrMaxElement(2, arr , false);
            Console.WriteLine(arr[maxI]);

            //find the minimum element in a portion of array
            Console.WriteLine("\nMinimum element:");
            int minI = FindMinOrMaxElement(2, arr, true);
            Console.WriteLine(arr[minI]);

            //ascending
            Console.WriteLine("\nAscending:");
            SelectionSort(2, new int[] { 1, -59, 12, 123, -56, 76, -4, 67, 45, 101, -35 }, false);

            //descending
            Console.WriteLine("\nDescending:");
            SelectionSort(2, new int[] { 1, -59, 12, 123, -56, 76, -4, 67, 45, 101, -35 }, true);
        }

        static int FindMinOrMaxElement(int startI, int[] arr, bool descending = false)
        {
            int bestValue = 0;
            int bestI = startI;
            for (int index = startI; index < arr.Length; index++)
            {
                //descending
                if (descending)
                {
                    if (arr[index] > bestValue)
                    {
                        bestI = index;
                        bestValue = arr[index];
                    }
                }
                //ascending
                else
                {
                    if (arr[index] < bestValue)
                    {
                        bestI = index;
                        bestValue = arr[index];
                    }
                }
            }
            return bestI;
        }

        static void SelectionSort(int startI, int[] arr, bool descending = false)
        {
            for (int curentIndex = startI; curentIndex < arr.Length - 1; curentIndex++)
            {
                int bestI = FindMinOrMaxElement(curentIndex, arr, descending);
                ExchangeValues(arr, curentIndex, bestI);
            }
            PrintArray(startI, arr);
        }

        static void ExchangeValues(int[] arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }

        static void PrintArray(int startI, int[] arr)
        {
            for (int index = startI; index < arr.Length; index++)
            {
                Console.Write(arr[index] + " ");
            }
            Console.WriteLine();
        }
    }
}
