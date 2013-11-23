using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06maxSumOfKElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads two integer numbers N and K and an array             //of N elements from the console. 
            //Find in the array those K elements that have maximal sum.

            //enter N and K
            Console.WriteLine("Enter the number N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number K:");
            int k = int.Parse(Console.ReadLine());

            // initialize and declare N array
            Console.WriteLine("Enter the array's elements:");
            int[] seq = new int[n];
            for (int index = 0; index < n; index++)
            {
	            seq[index] = int.Parse(Console.ReadLine());
            }

            //initialize an array in which will be saved the three biggest elements
            int[] maxSumK = new int[k];
            // find the three biggest elements
            int currentMax = int.MaxValue;

            for (int elementK = 0; elementK < maxSumK.Length; elementK++)
            {
	            int tempMin = int.MinValue;
	
	            for (int elementN = 0; elementN < seq.Length; elementN++)
	            {
		            if (tempMin < seq[elementN] && seq[elementN] < currentMax)
		            {
			            tempMin = seq[elementN];

		            }
	            }

	            maxSumK[elementK] = tempMin;
	            currentMax = tempMin;
            }

            //print the results
            int sum = 0;
            Console.Write("The elements are :");
            for (int index = 0; index < k; index++)
            {
	            Console.Write(" " + maxSumK[index]);
	            sum += maxSumK[index];
            }

            Console.WriteLine();
            Console.WriteLine("The max sum of K elements is {0}.", sum);

        }
    }
}
