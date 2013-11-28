using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a method that reverses the digits of given decimal number. Example: 256 -> 652

namespace _07ReverseDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            //input data
            Console.WriteLine("Please, enter a number:");
            decimal num = decimal.Parse(Console.ReadLine());

            //using the method
            ReverseDigits(num);

        }

        private static void ReverseDigits(decimal num)
        {
            char[] numChar = num.ToString().ToCharArray();
            for (int index = 0; index < numChar.Length / 2; index++)
            {
                char tempChar = numChar[index];
                numChar[index] = numChar[numChar.Length - 1 - index];
                numChar[numChar.Length - 1 - index] = tempChar;
            }
            for (int index = 0; index < numChar.Length; index++)
            {
                Console.Write(numChar[index]);
            }
            Console.WriteLine();
        }
    }
}
