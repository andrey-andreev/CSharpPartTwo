using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to convert decimal numbers to their binary representation.
namespace _01DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int decNum = 1384;
            Console.Write(decNum + " (decimal) -> ");
            int remainder = 1;
            int index = 0;
            int[] binaryArr = new int[1];
            while (decNum != 0)
            {
                remainder = decNum % 2;
	            decNum = decNum / 2;
	            binaryArr[index] = remainder;
	            index++;
                if (decNum != 0)
                {
                    Array.Resize(ref binaryArr, index + 1);
                }
            }
            Array.Reverse(binaryArr);
            PrintArray(binaryArr);
        }

        static void PrintArray(int[] arr)
        {
            for (int index = 0; index < arr.Length; index++)
            {
                Console.Write(arr[index]);
            }
            Console.WriteLine(" (binary)");
        }
    }
}
