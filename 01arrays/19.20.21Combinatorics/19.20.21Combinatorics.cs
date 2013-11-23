﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._20._21Combinatorics
{
    class Program
    {
        /*
         * 19.Write a program that reads a number N and generates and prints all the 
         * permutations of the numbers [1 … N]. Example:n = 3  {1, 2, 3}, {1, 3, 2}, 
         * {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}
         * 
         * 20.Write a program that reads two numbers N and K and generates all the variations 
         * of K elements from the set [1..N]. Example:	N = 3, K = 2  {1, 1}, {1, 2}, 
         * {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
         * 
         * 21.Write a program that reads two numbers N and K and generates all the combinations 
         * of K distinct elements from the set [1..N]. Example:	N = 5, K = 2  {1, 2}, {1, 3}, 
         * {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
         */
        static void Main()
        {
            Console.Write("Please enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter K: ");
            int k = int.Parse(Console.ReadLine());

            int[] subArray = new int[k];
            int[] intArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                intArray[i] = i + 1;
            }

            Console.WriteLine("Permutations: ");
            Permutations(intArray, n, 0);
            Console.WriteLine();
            Console.WriteLine("Variations: ");
            Variations(subArray, n, 0);
            Console.WriteLine();
            Console.WriteLine("Combinations: ");
            Combinations(subArray, n, 0, 0);
            Console.WriteLine();
        }

        static void Permutations(int[] permutations, int n, int firstIndex)
        {
            if (firstIndex == permutations.Length)
            {
                PrintArray(permutations);
            }
            else
            {
                for (int i = firstIndex; i < n; i++)
                {

                    Swap(ref permutations[i], ref permutations[firstIndex]);
                    Permutations(permutations, n, firstIndex + 1);
                    Swap(ref permutations[i], ref permutations[firstIndex]);
                }
            }
        }

        static void Variations(int[] variations, int n, int firstIndex)
        {
            if (firstIndex == variations.Length)
            {
                PrintArray(variations);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    variations[firstIndex] = i + 1;
                    Variations(variations, n, firstIndex + 1);
                }
            }
        }

        static void Combinations(int[] combinations, int n, int firstIndex, int secondIndex)
        {
            if (firstIndex == combinations.Length)
            {
                PrintArray(combinations);
            }
            else
            {
                for (int i = secondIndex; i < n; i++)
                {
                    combinations[firstIndex] = i + 1;
                    Combinations(combinations, n, firstIndex + 1, secondIndex + 1);
                }
            }
        }

        static void PrintArray(int[] intArray)
        {
            Console.Write("{");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i]);
                if (i < intArray.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.Write("} ");
        }

        static void Swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }
    }
}
