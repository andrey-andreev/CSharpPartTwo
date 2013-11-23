using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05findsTheMaximalIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds the maximal increasing sequence in an array. 
            //Example: {3, 2, 3, 4, 2, 2, 4} ? {2, 3, 4}.

            //input the array length
            Console.WriteLine("Please enter the array's length:");
            int size = int.Parse(Console.ReadLine());

            //initialize and declare the array
            Console.WriteLine("Please enter the array's elements:");
            int[] arr = new int[size];
            for (int index = 0; index < arr.Length; index++)
            {
	            arr[index] = int.Parse(Console.ReadLine());
            }

            //algorithm
            int startITemp = 0;
            int startI = 0;
            int endI = 1;
            int previousI = 0;
            int longestSoFar = 1;
            int longestTemp = 1;
            for (int index = 1; index < arr.Length; index++)
            {
	            if (arr[previousI] < arr[index])
	            {
		            longestTemp++;		
		            if (longestTemp > longestSoFar)
		            {
			            endI = index;
			            longestSoFar = longestTemp;
		            }
	            }
	            else //(arr[previousI] >= arr[index])
	            {
                    if (longestSoFar == longestTemp) //
                    {
                        startI = startITemp;
                    }
		            startITemp = index; // start new sequence
		            longestTemp = 1;
	            }
                previousI++;
            }

            //print the result
            Console.Write("The maximal increasing sequence is {");
            for (int index = startI; index < endI + 1; index++)
            {
	            Console.Write(arr[index]);
	            if (index < endI)
	            {
		            Console.Write(", ");
	            }
            }
            Console.WriteLine("}");

        }
    }
}
