using System;
using System.Text;
//Write a program that converts a string to a sequence of C# Unicode character literals. 
//Use format strings. Sample input:
//Hi!
//Expected output:
//\u0048\u0069\u0021
class StringToUnicode
{
    static void Main()
    {
        string text = "Hello, Mr. Anderson!";
        Console.WriteLine(ConvertToUnicode(text));
    }

    static string ConvertToUnicode(string text)
    {
        StringBuilder result = new StringBuilder(text.Length);
        foreach (char symbol in text)
        {
            result.AppendFormat(@"\u{0:X4}", (int)symbol);
        }
        return result.ToString();
    }
}