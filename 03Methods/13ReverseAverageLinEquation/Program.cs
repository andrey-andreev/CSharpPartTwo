using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Write a program that can solve these tasks:
    - Reverses the digits of a number
    - Calculates the average of a sequence of integers
    - Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
    - The decimal number should be non-negative
    - The sequence should not be empty
    - a should not be equal to 0
*/
namespace _13ReverseAverageLinEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chose which task you want to solve:");
            Console.WriteLine("PRESS 1 to Reverses the digits of a number.");
            Console.WriteLine("PRESS 2 to Calculates the average of a sequence of integers.");
            Console.WriteLine("PRESS 3 to Solves a linear equation a*x+b=0.");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                InputReverseDigits();
            }
            else if (choice == 2)
            {
                InputAverage();
            }
            else if (choice == 3)
            {
                InputLinearEquation();
            }

        }
        //REVERSE
        static void InputReverseDigits()
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            if (num >= 0)
            {
                Console.WriteLine("Reverse digits: {0}", ReverseDigits(num));
                
            }
            else
            {
                Console.WriteLine("The number should be non-negative.");
            }
        }

        static int ReverseDigits(int num)
        {
            int result = 0;
            while (num != 0)
            {
                result *= 10;
                int digit = num % 10;
                num = num / 10;
                result += digit;
            }
            return result;
        }
        //AVERAGE
        static void InputAverage()
        {
            Console.WriteLine("Enter the length of the sequence:");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            if (length > 0)
            {
                Console.WriteLine("Average of the sequence is: {0}", CalcAverage(arr));
            }
            else
            {
                Console.WriteLine("The sequence is empty.");
            }
        }

        static double CalcAverage(int[] arr)
        {
            double sum = 0;
            foreach (var element in arr)
            {
                sum += element;
            }
            sum /= arr.Length;
            return sum;
        }
        //LINEAR EQUATION
        static void InputLinearEquation()
        {
            Console.WriteLine("Enter a:");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            decimal b = decimal.Parse(Console.ReadLine());
            if (a != 0)
            {
                Console.WriteLine("x = {0}", LinearEquation(a, b));
            }
            else
            {
                Console.WriteLine("a should not be equal to 0.");
            }
        }

        static decimal LinearEquation(decimal a, decimal b)
        {
            decimal x = -b / a;
            return x;
        }
    }
}
