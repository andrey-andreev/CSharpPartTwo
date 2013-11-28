using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write methods to calculate minimum, maximum, average, sum and product of given set of 
 * integer numbers. Use variable number of arguments.
 */

namespace _14Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers: (4, 8, -12, 23, -45, 60).");
            Console.WriteLine("Minimum: {0}", FindMinimum(4, 8, -12, 23, -45, 60));
            Console.WriteLine("Maximum: {0}", FindMaximum(4, 8, -12, 23, -45, 60));
            Console.WriteLine("Average: {0}", CalcAverage(4, 8, -12, 23, -45, 60));
            Console.WriteLine("Sum    : {0}", CalcSum(4, 8, -12, 23, -45, 60));
            Console.WriteLine("Product: {0}", CalcProduct(4, 8, -12, 23, -45, 60));
        }

        static int FindMinimum(params int[] arr)
        {
            int min = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                
            }
            return min;
        }

        static int FindMaximum(params int[] arr)
        {
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

            }
            return max;
        }

        static int CalcAverage(params int[] arr)
        {
            int sum = 0;
            foreach (var el in arr)
            {
                sum += el;
            }
            int average = sum / arr.Length;
            return average;
        }

        static int CalcSum(params int[] arr)
        {
            int sum = 0;
            foreach (var el in arr)
            {
                sum += el;
            }
            return sum;
        }

        static int CalcProduct(params int[] arr)
        {
            int product = 1;
            foreach (var el in arr)
            {
                product *= el;
            }
            return product;
        }
    }
}
