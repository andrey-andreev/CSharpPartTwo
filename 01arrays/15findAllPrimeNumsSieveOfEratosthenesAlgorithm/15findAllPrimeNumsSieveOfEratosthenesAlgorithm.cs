using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15findAllPrimeNumsSieveOfEratosthenesAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds all prime numbers in the range [1...10 000 000]. 
            //Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

            //initialize the array
            bool[] arr = new bool[10000001];

            //sieve of Eratosthenes algorithm
            int prime = 1;

            for (int index = 1; index < arr.Length; index++)
            {
                if (prime < index && arr[index] == false)
                {
                    Console.Write(" " + index);
                    prime = index;
                    for (int multiplier = 0; multiplier < arr.Length / prime + 1; multiplier++)
                    {
                        int markIndex = prime * multiplier;
                        arr[markIndex] = true;
                    }
                }
            }
            Console.WriteLine();

        }
    }
}
