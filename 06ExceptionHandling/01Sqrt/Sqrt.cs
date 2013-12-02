using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a program that reads an integer number and calculates and prints its square root. If the number 
// is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.


class Sqrt
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a n integer:");
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                throw new FormatException();
            }
            Console.WriteLine("The sqrt of {0} is {1}.", num, Math.Sqrt(num));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye!!!");
        }


    }
}

