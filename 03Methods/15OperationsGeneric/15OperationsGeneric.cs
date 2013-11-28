using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Modify your last program and try to make it work for any number type, not just 
 * integer (e.g. decimal, float, byte, etc.). Use generic method (read in Internet 
 * about generic methods in C#).
 */
namespace _15OperationsGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers: (4.45, 8.36, -12.36, 23.47, -45.76, 60.87).");
            Console.WriteLine("Minimum: {0}", FindMinimum(4.45m, 8.36m, -12.36m, 23.47m, -45.76m, 60.87m));
            Console.WriteLine("Maximum: {0}", FindMaximum(4.45m, 8.36m, -12.36m, 23.47m, -45.76m, 60.87m));
            Console.WriteLine("Average: {0}", CalcAverage(4.45m, 8.36m, -12.36m, 23.47m, -45.76m, 60.87m));
            Console.WriteLine("Sum    : {0}", CalcSum(4.45m, 8.36m, -12.36m, 23.47m, -45.76m, 60.87m));
            Console.WriteLine("Product: {0}", CalcProduct(4.45m, 8.36m, -12.36m, 23.47m, -45.76m, 60.87m));
        }

        static T FindMinimum<T>(params T[] arr)
        {
            dynamic min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                
            }
            return min;
        }

        static T FindMaximum<T>(params T[] arr)
        {
            dynamic max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

            }
            return max;
        }

        static T CalcAverage<T>(params T[] arr)
        {
            dynamic sum = 0;
            foreach (var el in arr)
            {
                sum += el;
            }
            dynamic average = sum / arr.Length;
            return average;
        }

        static T CalcSum<T>(params T[] arr)
        {
            dynamic sum = 0;
            foreach (var el in arr)
            {
                sum += el;
            }
            return sum;
        }

        static T CalcProduct<T>(params T[] arr)
        {
            dynamic product = 1;
            foreach (var el in arr)
            {
                product *= el;
            }
            return product;
        }
    }
}
