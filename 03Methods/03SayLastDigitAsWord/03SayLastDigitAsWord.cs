using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03SayLastDigitAsWord
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a method that returns the last digit of given integer as an English word. 
             * Examples: 512  "two", 1024  "four", 12309  "nine".
             */

            //initialize and declare a random number
            Random random = new Random();
            int randomNum = random.Next(1, 1000);
            Console.WriteLine("The number is :" + randomNum);

            //extract the last digit from the number
            int lastDigit = randomNum % 10;

            //using the method to print the method
            Console.Write("The last digit of number {0} is ",randomNum);
            sayLastDigitAsWord(lastDigit);

        }

        static void sayLastDigitAsWord(int num)
        {
            switch (num)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eigth");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                default:
                    break;
            }
        }
    }
}
