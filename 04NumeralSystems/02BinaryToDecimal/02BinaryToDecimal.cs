using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to convert binary numbers to their decimal representation.

namespace _02BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int binaryNum = 1010110100;
            Console.Write(binaryNum + " (binary)");
            int decimalNum = 0;
            int power = 0;
            while (binaryNum != 0)
            {
                //extract rightmost bit value
                int bitValue = binaryNum % 2;
                //calculate the decimal representation
                decimalNum += bitValue * (int)(Math.Pow(2,power));
                //cut the rightmost bit
                binaryNum /= 10;
                //increase the power
                power++;
            }
            Console.WriteLine(" -> {0} (decimal)", decimalNum);
        }
    }
}
