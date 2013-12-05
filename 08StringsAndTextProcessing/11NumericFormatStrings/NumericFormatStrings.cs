using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a number and prints it as a decimal number, hexadecimal 
//number, percentage and in scientific notation. Format the output aligned right 
//in 15 symbols.
namespace _11NumericFormatStrings
{
    class NumericFormatStrings
    {
        static void Main(string[] args)
        {
            int num = 932056846;
            Console.WriteLine(String.Format("{0,15:.0}", num));
            Console.WriteLine(String.Format("{0,15:0%}", num));
            Console.WriteLine(String.Format("{0,15:X}", num));
            Console.WriteLine(String.Format("{0,15:E}", num));
        }
    }
}
