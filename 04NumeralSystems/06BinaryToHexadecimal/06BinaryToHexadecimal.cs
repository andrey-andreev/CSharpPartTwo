using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06BinaryToHexadecimal
{
    class Program
    {
        static void Main()
        {
            int binNum = 1011110001; // 0010 1111 0001 (2) -> (16)
            Console.Write("{0} (2) ->  ", binNum);
            //char[] hexaChar = binNum.ToCharArray();
            Console.WriteLine("{0} (16)", ConvertBinToHexa(binNum));
        }


        static string ConvertBinToHexa(int num)
        {
            char[] arr = new char[0];
            int halfByte = 0;
            int digit = 0;
            while (num != 0)
            {
                Array.Resize(ref arr, digit + 1);
                halfByte = num % 10000;
                num /= 10000;
                switch (halfByte)
                {
                    case 0: arr[digit] = '0';
                        break;
                    case 1: arr[digit] = '1';
                        break;
                    case 10: arr[digit] = '2';
                        break;
                    case 11: arr[digit] = '3';
                        break;
                    case 100: arr[digit] = '4';
                        break;
                    case 101: arr[digit] = '5';
                        break;
                    case 110: arr[digit] = '6';
                        break;
                    case 111: arr[digit] = '7';
                        break;
                    case 1000: arr[digit] = '8';
                        break;
                    case 1001: arr[digit] = '9';
                        break;
                    case 1010: arr[digit] = 'A';
                        break;
                    case 1011: arr[digit] = 'B';
                        break;
                    case 1100: arr[digit] = 'C';
                        break;
                    case 1101: arr[digit] = 'D';
                        break;
                    case 1110: arr[digit] = 'E';
                        break;
                    case 1111: arr[digit] = 'F';
                        break;
                    default: arr[digit] = ' ';
                        break;
                }
                digit++;
            }
            Array.Reverse(arr);
            string result = new string(arr);

            return result;
        }
    }
}
