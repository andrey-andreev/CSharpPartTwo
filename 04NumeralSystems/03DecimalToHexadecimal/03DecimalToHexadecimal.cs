using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to convert decimal numbers to their hexadecimal representation.

namespace _03DecimalToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {

            int decNum = 4095;
            Console.Write(decNum + " (decimal) -> ");
            int remainder = 1;
            int index = 0;
            int[] hexadecimalArr = new int[1];
            while (decNum != 0)
            {
                remainder = decNum % 16;
                decNum = decNum / 16;
                hexadecimalArr[index] = remainder;
                index++;
                if (decNum != 0)
                {
                    Array.Resize(ref hexadecimalArr, index + 1);
                }
            }
            Array.Reverse(hexadecimalArr);
            PrintArray(hexadecimalArr);
        }

        static void PrintArray(int[] arr)
        {
            for (int index = 0; index < arr.Length; index++)
            {
                if (arr[index] < 10)
                {
                    Console.WriteLine(arr[index]);
                }
                else
                {
                    switch (arr[index])
                    {
                        case 10: Console.Write("A");
                            break;
                        case 11: Console.Write("B");
                            break;
                        case 12: Console.Write("C");
                            break;
                        case 13: Console.Write("D");
                            break;
                        case 14: Console.Write("E");
                            break;
                        case 15: Console.Write("F");
                            break;
                        default:
                            break;
                    }
                }
                
            }
            Console.WriteLine(" (hexadecimal)");
        }
    }
}
