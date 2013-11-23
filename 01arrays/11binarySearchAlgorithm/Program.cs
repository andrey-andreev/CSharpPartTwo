using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11binarySearchAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that finds the index of given element in a sorted array of 
            integers by using the binary search algorithm (find it in Wikipedia). */

            //input the array's length
            Console.WriteLine("Input the array's length:");
            int n = int.Parse(Console.ReadLine());

            //input the wanted element 
            Console.WriteLine("Input the wanted number:");
            int num = int.Parse(Console.ReadLine());

            //declare and initialize the array
            int[] arr = new int[n];
            
            for (int index = 0; index < arr.Length; index++)
            {
                Console.Write("Element {0}:", index);
	            arr[index] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            //sort the array
            Array.Sort(arr);
            Console.WriteLine("This is the sorted array:");
            for (int index = 0; index < arr.Length; index++)
            {
                Console.WriteLine("element{0,3}: {1}", index, arr[index]);
            }

            //binary search algorithm
            int start = 0;
            int end = n - 1;
            bool isNumExist = false;

            while (start <= end)
            {
                int compareIndex = (start + end) / 2;
	            if (num < arr[compareIndex])
	            {
                    end = compareIndex - 1;
	            }
	            else if (num > arr[compareIndex])
	            {
		            start = compareIndex + 1;
	            }
                else
                {
                    Console.WriteLine("The element {0} have index {1}. ", num, compareIndex);
                    isNumExist = true;
                    break;
                }
            }
            //print the result
            if (!isNumExist)
            {
                Console.WriteLine("The wanted number does not exist in the given array.");
            }

        }
    }
}
