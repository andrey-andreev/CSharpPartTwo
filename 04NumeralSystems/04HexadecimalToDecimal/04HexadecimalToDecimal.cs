using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to convert hexadecimal numbers to their decimal representation.

namespace _04HexadecimalToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexaNum = "C1A2F";
            Console.Write(hexaNum + " (hexadecimal)");
            char[] hexaArrChar = hexaNum.ToCharArray();
            int[] hexaArrInt = new int[hexaArrChar.Length];
            hexaArrInt = Convert(hexaArrChar);
            //
            int result = 0;
            Array.Reverse(hexaArrInt);
            for (int power = 0; power < hexaArrInt.Length; power++)
            {
                result += hexaArrInt[power] * (int)(Math.Pow(16, power));
            }
            Console.WriteLine(" -> {0} (decimal)", result);
        }

        static int[] Convert(char[] arrChar)
        {
            int[] arrInt = new int[arrChar.Length];
            for (int index = 0; index < arrChar.Length; index++ )
            {
                switch (arrChar[index])
                {
                    case '0': arrInt[index] = 0;
                        break;
                    case '1': arrInt[index] = 1;
                        break;
                    case '2': arrInt[index] = 2;
                        break;
                    case '3': arrInt[index] = 3;
                        break;
                    case '4': arrInt[index] = 4;
                        break;
                    case '5': arrInt[index] = 5;
                        break;
                    case '6': arrInt[index] = 6;
                        break;
                    case '7': arrInt[index] = 7;
                        break;
                    case '8': arrInt[index] = 8;
                        break;
                    case '9': arrInt[index] = 9;
                        break;
                    case 'A': arrInt[index] = 10;
                        break;
                    case 'B': arrInt[index] = 11;
                        break;
                    case 'C': arrInt[index] = 12;
                        break;
                    case 'D': arrInt[index] = 13;
                        break;
                    case 'E': arrInt[index] = 14;
                        break;
                    case 'F': arrInt[index] = 15;
                        break;
                    default:
                        break;
                }
            }
            return arrInt;
        }
    }
}
