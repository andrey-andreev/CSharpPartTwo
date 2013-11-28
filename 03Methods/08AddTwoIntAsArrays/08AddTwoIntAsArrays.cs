using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
/* Write a method that adds two positive integer numbers represented as arrays of 
 * digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
 * Each of the numbers that will be added could have up to 10 000 digits.
 */

namespace _08AddTwoIntAsArrays
{
    class Program
    {
        static void Main()
        {
            //TEST INPUT DATA
            //PrintArray(Add(100, 0));
            //Console.WriteLine(100 + 0);
            //PrintArray(Add(1, 1));
            //Console.WriteLine(1 + 1);
            //PrintArray(Add(10, 1));
            //Console.WriteLine(10 + 1);
            //PrintArray(Add(1, 9));
            //Console.WriteLine(1 + 9);
            //PrintArray(Add(1, 99));
            //Console.WriteLine(1 + 99);
            //PrintArray(Add(1, 999));
            //Console.WriteLine(1 + 999);
            //PrintArray(Add(1, 9998));
            //Console.WriteLine(1 + 9998);
            //PrintArray(Add(1, 999876));
            //Console.WriteLine(1 + 999876);
            //PrintArray(Add(12, 8899981));
            //Console.WriteLine(12 + 8899981);

            //input data from the user
            Console.WriteLine("Plese, enter two positive integer numbers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            PrintArray(Add(num1, num2));
            
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

        static int[] Add(int num1, int num2)
        {
            int[] addend1 = ConvertNumToArray(num1);
            int[] addend2 = ConvertNumToArray(num2);

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
                if (addend1[digit] + addend2[digit] + result[digit]> 9)
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
            if (arr[arr.Length - 1] != 0)
            {
                Console.Write(arr[arr.Length - 1]);
            }
            for (int index = arr.Length - 2; index >= 0; index--)
            {
                Console.Write(arr[index]);
            }
            Console.WriteLine();
        }
    }
}
