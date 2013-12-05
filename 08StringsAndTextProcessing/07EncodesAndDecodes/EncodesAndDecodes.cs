using System;
using System.Text;
//Write a program that encodes and decodes a string using given encryption key (cipher). The key consists 
//of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) operation over 
//the first letter of the string with the first of the key, the second – with the second, etc. When the last 
//key character is reached, the next is the first.

namespace _07EncodesAndDecodes
{
    class EncodesAndDecodes
    {
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else.";
            string key = "34j890gfh08";
            Console.WriteLine("Before the encoding:\n" + text);

            string encrypt = Encode(text, key);
            Console.WriteLine("\nAfter the encoding:");
            Console.WriteLine(encrypt);

            string decrypt = Decode(encrypt, key);
            Console.WriteLine("\nAfter the decoding:");
            Console.WriteLine(decrypt);
            Console.WriteLine();
        }

        static string Encode(string text, string key)
        {
            StringBuilder result = new StringBuilder();
            int keyIndex = 0;
            for (int index = 0; index < text.Length; index++)
            {
                if (index > key.Length - 1)
                {
                    keyIndex = 0;
                }
                result.Append((char)(text[index] ^ key[keyIndex]));
                keyIndex++;
            }
            return result.ToString();
        }

        static string Decode(string text, string key)
        {
            return Encode(text, key);
        }
    }
}
