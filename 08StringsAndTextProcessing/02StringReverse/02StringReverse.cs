using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a program that reads a string, reverses it and prints the result at the console.
// Example: "sample"  "elpmas".

namespace _02StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "sample";
            Console.WriteLine("Before: " + str);
            char[] charArr = str.ToCharArray();
            Array.Reverse(charArr);
            //str = Array.ToString(charArr);
            string newStr = new string(charArr);
            Console.WriteLine("After:  " + newStr);

        }
    }
}
