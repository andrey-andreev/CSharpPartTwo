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
            bool[] arr = new bool[104730];

            //sieve of Eratosthenes algorithm
            long prime = 1;

            for (long index = 1; index < arr.Length; index++)
            {
                if (prime < index && arr[index] == false)
                {
                    Console.Write(" " + index);
                    prime = index;
                    for (long multiplier = prime; multiplier < arr.Length / prime; multiplier++)
                    {
                        long markIndex = prime * multiplier;
                        arr[markIndex] = true;
                    }
                }
            }
            Console.WriteLine();

        }
    }
}
