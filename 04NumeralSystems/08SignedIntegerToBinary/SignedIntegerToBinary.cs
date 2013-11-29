using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
class SignedIntegerToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter a number between -32,768 and 32,767: ");
        int num = int.Parse(Console.ReadLine());
        string binNumber = String.Empty;
        List<int> bits = new List<int>();

        // when the number < 0
        if (num < 0)
        {
            num = Math.Abs(num) - 1;
 
            while (num != 0)
            {
                bits.Add(num % 2);
                num /= 2;
            }
 
            bits.Reverse();
 
            for (int i = 0; i < bits.Count; i++)
            {
                if (bits[i] == 0)
                {
                    binNumber += "1";
                }
                else
                {
                    binNumber += "0";
                }
            }
 
            while (binNumber.Length % 16 != 0)
            {
                binNumber = "1" + binNumber;
            }
            Console.WriteLine("The binary representation of your number is {0}.", binNumber);
        }
            
        
        // when the number >= 0
        else
        {
            num = Math.Abs(num) - 1;

            while (num != 0)
            {
                bits.Add(num % 2);
                num /= 2;
            }

            bits.Reverse();

            for (int i = 0; i < bits.Count; i++)
            {
                if (bits[i] == 0)
                {
                    binNumber += "1";
                }
                else
                {
                    binNumber += "0";
                }
            }

            while (binNumber.Length % 16 != 0)
            {
                binNumber = "1" + binNumber;
            }
            Console.WriteLine("The binary representation of your number is {0}.", binNumber);
        }

    }
}

