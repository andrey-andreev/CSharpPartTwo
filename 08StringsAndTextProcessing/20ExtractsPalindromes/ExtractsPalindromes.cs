using System.IO;
using System;
using System.Text.RegularExpressions;
//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

namespace _20ExtractsPalindromes
{
    class ExtractsPalindromes
    {
        static void Main(string[] args)
        {
            string text = "lamal sadfgsdf abba sdfgdsf exe sdfgdf";
            string pattern = @"(\w)(?:(?R)|\w?)$1"; // \b(\w)+(\w?|(?R))*($1)\b
            //string pattern = @"(\w)(?:(?R)|\w?)$1";
            foreach (Match m in Regex.Matches(text, pattern))
            {
                Console.WriteLine(m.Value);
            }
        }
    }
}

//http://www.rexegg.com/regex-recursion.html
//\b(\w)+(\w|(?R))*($1)\b
//http://forums.academy.telerik.com/56626/c%23-%D0%B4%D0%BE%D0%BC%D0%B0%D1%88%D0%BD%D0%BE-strings-and-text-processing-20-%D0%B7%D0%B0%D0%B4%D0%B0%D1%87%D0%B0?start=0#a_list_title