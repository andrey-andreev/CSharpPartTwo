using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09findsTheMostFrequentNumberInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that finds the most frequent number in an array. 
            Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} ? 4 (5 times) */
            
            //get the array length
            Console.WriteLine("Enter the length of the array:");
            int n = int.Parse(Console.ReadLine());

            //initialize and declare the array
            int[] arr = new int[n];
            Console.WriteLine("Enter the array's elements:");
            for (int index = 0; index < arr.Length; index++)
            {
	            arr[index] = int.Parse(Console.ReadLine());
            }

            //algorithm
            int maxCount = 0;
            int maxIndex = 0;
            for (int index = 0; index < n - 1; index++)
            {
	            int count = 0;
	            for (int compareIndex = index; compareIndex < n; compareIndex++)
	            {
		            if (arr[index] == arr[compareIndex])
		            {
			            count += 1;
		            }
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxIndex = compareIndex;
                    }
	            }
	            
            }

            Console.WriteLine("The most frequent number in an array is {0} ({1} times)", arr[maxIndex], maxCount);

        }
    }
}
