using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04findsTheMaximalSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that finds the maximal sequence of equal elements in an array.
            // Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} ? {2, 2, 2}.

            Console.WriteLine("Enter the length of sequence:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the the sequence elements:");

            // declare and initialize the sequence array
            int[] seqArr = new int[n];
            for (int index = 0; index < n; index++)
            {
	            seqArr[index] = int.Parse(Console.ReadLine());
            }

            // find the longest sequence of equal elements in the array
            int longestCount = 0;
            int count = 1;
            int longestIndex = 0;

            for (int index = 0; index < n - 1; index++)
            {
	            if (seqArr[index] == seqArr[index + 1])
	            {
		            count += 1;
		
	            }
	            else
	            {
		            if (count > longestCount)
		            {
			            longestCount = count;
			            longestIndex = index;
		            }

		            count = 1;
	            }
            }
            Console.Write("The maximal sequence of equal elements in the array is :");
            for (int index = 0; index < longestCount; index++)
            {
                Console.Write(" " + seqArr[longestIndex]);
            }
            Console.WriteLine();

        }
    }
}
