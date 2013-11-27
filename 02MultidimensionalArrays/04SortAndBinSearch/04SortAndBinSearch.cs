using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program, that reads from the console an array of N integers and an integer K, sorts the 
 * array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 
 */

namespace _04SortAndBinSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //input test data
            Console.WriteLine("Please enter N (the length of the array):");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter K:");
            int k = int.Parse(Console.ReadLine());
            int[] arrN = new int[n];
            Console.WriteLine("Enter the array's elements:");
            for (int index = 0; index < arrN.Length; index++)
            {
                arrN[index] = int.Parse(Console.ReadLine());
            }

            //print the array before the sorting
            Console.WriteLine("This is you array:");
            foreach (var num in arrN)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");

            //sort the array
            Array.Sort(arrN);

            //print the array after the sorting
            Console.WriteLine("This is your array sorted ascending:");
            foreach (var num in arrN)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");

            //use binary search to find the largest number in the array which is ≤ K
            int bestIndex = Array.BinarySearch(arrN, k);

            if (bestIndex < 0)
            {
                bestIndex = Math.Abs(bestIndex);    
                if (bestIndex - 2 < 0)
                {
                    Console.WriteLine("Number K is lower than all of the elements in the array.");
                }
                else
                {
                    Console.WriteLine("The largest number in the array which is <=K is {0} with index {1}.", arrN[bestIndex - 2], bestIndex - 2);
                }
                
            }
            else
            {
                Console.WriteLine("The largest number in the array which is <=K is {0} with index {1}.", arrN[bestIndex], bestIndex);
            }
            //print the array after the sorting
        }
    }
}
