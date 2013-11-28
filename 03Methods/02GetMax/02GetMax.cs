using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02GetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a method GetMax() with two parameters that returns the bigger of two integers. 
             * Write a program that reads 3 integers from the console and prints the biggest of 
             * them using the method GetMax().
             */

            //initialize and declare a random numbers
            Random random = new Random();
            int firstNum = random.Next(1, 1000);
            int secondNum = random.Next(1, 1000);
            int thirdNum = random.Next(1, 1000);
            Console.WriteLine("First number is :" + firstNum);
            Console.WriteLine("Second number is :" + secondNum);
            Console.WriteLine("Third number is :" + thirdNum);

            //using the method to get the biggest number 
            int biggestOfTwo = GetMax(firstNum, secondNum);
            int maxNum = GetMax(biggestOfTwo, thirdNum);

            //print the result
            Console.WriteLine("The biggest number is:" + maxNum);


        }

        static int GetMax (int firstNum, int secondNum)
        {
            int biggestNum = firstNum;
            if (firstNum < secondNum)
            {
                biggestNum = secondNum;
            }
            return biggestNum;
        }
    }
}
