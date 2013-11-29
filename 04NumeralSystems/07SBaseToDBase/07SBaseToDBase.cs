using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

namespace _07SBaseToDBase
{
    class Program
    {
        static void Main()
        {
            sBaseToDBase(2, 16, "10101110");    // AE
            sBaseToDBase(2, 8, "10101110");     // 256
            sBaseToDBase(8, 2, "3764");         // 111 1111 0100
            sBaseToDBase(8, 16, "3764");        // 7F4

        }

        private static void sBaseToDBase(int s, int d, string num)
        {
            string temp = String.Empty;
            if (s < d)
            {
                temp = MultiplyConvert(s, num);
                temp = DivisionConvert(d, temp);
            }
            else // s > d
            {
                temp = DivisionConvert(s, num);
                temp = MultiplyConvert(d, temp);
            }
            Console.WriteLine("{0} ({1}) -> {2} ({3})", num, s, temp, d);
        }

        static string MultiplyConvert(int sBase, string num)
        {
            char[] numArrChar = num.ToCharArray();
            Array.Reverse(numArrChar);
            int[] numArrInt = ConvertCharArrayToIntArray(numArrChar);

            int result = 0;
            for (int power = 0; power < numArrInt.Length; power++)
            {
                result += numArrInt[power] * (int)(Math.Pow(sBase, power));
            }
            string strResult = result.ToString();
            return strResult;
        }

        static string DivisionConvert(int dBase, string num)
        {
            int numInt = int.Parse(num);
            int remainder = 1;
            int[] arr = new int[1];
            int index = 0;

            while (numInt != 0)
            {
                index++;
                remainder = numInt % dBase;
                numInt /= dBase;
                arr[index - 1] = remainder;
                if (numInt != 0)
                {
                    Array.Resize(ref arr, index + 1);
                }
            }
            char[] arrChar = ConvertIntArrayToCharArray(arr);
            string result = new string(arrChar);

            return result;
        }

        static int[] ConvertCharArrayToIntArray(char[] arr)
        {
            int[] result = new int[arr.Length];
            for (int index = 0; index < arr.Length; index++)
			{
			    switch (arr[index])
                {
                    case '0': 
                        result[index] = 0; 
                        break;
                    case '1': 
                        result[index] = 1; 
                        break;
                    case '2': 
                        result[index] = 2; 
                        break;
                    case '3': 
                        result[index] = 3; 
                        break;
                    case '4': 
                        result[index] = 4; 
                        break;
                    case '5': 
                        result[index] = 5; 
                        break;
                    case '6': 
                        result[index] = 6; 
                        break;
                    case '7': 
                        result[index] = 7; 
                        break;
                    case '8': 
                        result[index] = 8; 
                        break;
                    case '9': 
                        result[index] = 9; 
                        break;
                    case 'A': 
                        result[index] = 10; 
                        break;
                    case 'B': 
                        result[index] = 11; 
                        break;
                    case 'C': 
                        result[index] = 12; 
                        break;
                    case 'D': 
                        result[index] = 13; 
                        break;
                    case 'E': 
                        result[index] = 14; 
                        break;
                    case 'F': 
                        result[index] = 15; 
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
			}
            return result;
        }

        static char[] ConvertIntArrayToCharArray(int[] arr)
        {
            char[] result = new char[arr.Length];
            for (int index = 0; index < arr.Length; index++)
            {
                switch (arr[index])
                {
                    case 0:
                        result[index] = '0';
                        break;
                    case 1:
                        result[index] = '1';
                        break;
                    case 2:
                        result[index] = '2';
                        break;
                    case 3:
                        result[index] = '3';
                        break;
                    case 4:
                        result[index] = '4';
                        break;
                    case 5:
                        result[index] = '5';
                        break;
                    case 6:
                        result[index] = '6';
                        break;
                    case 7:
                        result[index] = '7';
                        break;
                    case 8:
                        result[index] = '8';
                        break;
                    case 9:
                        result[index] = '9';
                        break;
                    case 10:
                        result[index] = 'A';
                        break;
                    case 11:
                        result[index] = 'B';
                        break;
                    case 12:
                        result[index] = 'C';
                        break;
                    case 13:
                        result[index] = 'D';
                        break;
                    case 14:
                        result[index] = 'E';
                        break;
                    case 15:
                        result[index] = 'F';
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
            }
            return result;
        }
    }
}
