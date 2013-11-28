using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04CountsANumberRepeatedInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a method that counts how many times given number appears in given array. 
             * Write a test program to check if the method is working correctly.
             */

            //test 1
            Console.WriteLine("test 1");
            PrintArray(-1, new int[] { -1, 3, 1, 4, 5, 6, 1 });

            //test 2
            Console.WriteLine("test 2");
            PrintArray(3, new int[] { 1, 3, 4, 3, 3, 5, 3 });

            //test 3
            Console.WriteLine("test 3");
            PrintArray(5, new int[] { 5, 5, 5, 5, 5, 5, 5 });

        }

        private static void PrintArray(int wantedNum, int[] myArr)
        {
            //print the the wanted number and the array
            Console.Write("This is the array: {");
            for (int index = 0; index < myArr.Length; index++)
            {
                Console.Write(myArr[index]);
                if (index < myArr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("}");
            Console.WriteLine("The wanted number {0} is repeated {1} times in the array. \n", wantedNum, CountsANumberRepeatedInArray(wantedNum, myArr));
        }

        static int CountsANumberRepeatedInArray(int num, int[] myArr)
        {
            int count = 0;
            for (int index = 0; index < myArr.Length; index++)
            {
                if (num == myArr[index])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
