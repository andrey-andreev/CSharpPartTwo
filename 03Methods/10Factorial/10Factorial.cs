
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
/* Write a program to calculate n! for each n in the range [1..100]. Hint: Implement 
 * first a method that multiplies a number represented as array of digits by given integer number. 
 */

namespace _10Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] factorial = { 1 };
            for (int index = 1; index <= 100; index++)
            {
                factorial = Multiplication(factorial, index);
                Console.Write("{0}! = ", index);
                PrintArray(factorial);
                Console.WriteLine();
            }
        }

        static int[] Multiplication(int[] arr, int num)
        {
            int[] result = { 0 };
            for (int i = 0; i < num; i++)
            {

                result = Add(result, arr);
            }
            return result;
        }

        static int[] ConvertNumToArray(int num)
        {

            int digitsCount = 0;
            int temp = num;
            //count the digits of the number
            while (temp > 0)
            {
                temp /= 10;
                digitsCount++;
            }
            int[] arr = new int[digitsCount];
            //extract the number digits in an array
            for (int i = 0; i < digitsCount; i++)
            {
                arr[i] = num % 10;
                num /= 10;
            }
            return arr;
        }

        static int[] Add(int[] addend1, int[] addend2)
        {
            int length = addend1.Length + 1;
            if (addend1.Length < addend2.Length)
            {
                length = addend2.Length + 1;
            }
            Array.Resize(ref addend1, length);
            Array.Resize(ref addend2, length);
            int[] result = new int[length];
            bool plusOne = false;
            for (int digit = 0; digit < result.Length; digit++)
            {
                //add one from prevous digit
                if (plusOne)
                {
                    result[digit]++;
                }
                //
                plusOne = false;
                //mark if we have to add 1 to the next digit
                if (addend1[digit] + addend2[digit] + result[digit] > 9)
                {
                    plusOne = true;
                }
                //calculate the digit
                result[digit] = result[digit] + addend1[digit] + addend2[digit];
                if (plusOne)
                {
                    result[digit] %= 10;
                }

            }
            return result;
        }

        static void PrintArray(int[] arr)
        {
            bool leadZero = true;
            if (arr[arr.Length - 1] != 0)
            {
                Console.Write(arr[arr.Length - 1]);
            }
            for (int index = arr.Length - 2; index >= 0; index--)
            {
                if (arr[index] != 0)
                {
                    leadZero = false;
                }
                if (leadZero)
                {
                    continue;
                }
                Console.Write(arr[index]);
            }
            Console.WriteLine();
        }
    }
}
