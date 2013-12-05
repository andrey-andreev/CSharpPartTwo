using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads from the console a string of maximum 20 characters. If the length of the string //is less than 20, the rest of the characters should be filled with '*'. Print the result string into the console.
namespace _06PadRight
{
    class PadRight
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string:");
            string inputString = Console.ReadLine();
            if (inputString.Length > 20)
            {
                inputString = inputString.Remove(20, inputString.Length - 20);
            }
            Console.WriteLine(inputString.PadRight(20, '*'));
        }
    }
}
