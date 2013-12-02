using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a method ReadNumber(int start, int end) that enters an integer number in 
// given range [start…end]. If an invalid number or non-number text is entered, the 
// method should throw an exception. Using this method write a program that 
// enters 10 numbers:	a1, a2, … a10, such that 1 < a1 < … < a10 < 100

class ReadNumbers
{
    static int ReadNumber(int start, int end)
    {
        
            Console.WriteLine("Enter a integer:");
            int num = int.Parse(Console.ReadLine());
            if (num < start || end < num)
            {
                throw new ArgumentOutOfRangeException();
            }
            start = num;
            return start;

    }

    static void Main(string[] args)
    {
        try
        {
            int start = 0;
            int end = 100;
            for (int i = 0; i < 10; i++)
            {
                start = ReadNumber(start, end);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Your input is not an integer.");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Your number is out of range.");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Your input can't be empty.");
        }
    }
}

