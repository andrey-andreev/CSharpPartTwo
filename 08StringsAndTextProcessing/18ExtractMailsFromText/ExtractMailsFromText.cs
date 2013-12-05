using System.IO;
using System;
using System.Text.RegularExpressions;
//Write a program for extracting all email addresses from given text. All substrings that match the 
//format <identifier>@<host>…<domain> should be recognized as emails.
namespace _18ExtractMailsFromText
{
    class ExtractMailsFromText
    {
        static void Main()
        {
            string text = "svirka@kaval.com 87ret098y40 sladurana@duduk.net ververtv -123--@usa.net, rvtervrev test.test123@en.some-host.12345.com";
            //string text = "rthtjhftyhjt test-1.p46@ala-bala.somehost.somewhere.bg sghdrthbnrth  eyheyhetyh";
            string pattern = @"\b([a-zA-Z0-9_\-][a-zA-Z0-9_\-\.]{0,49})@(([a-zA-Z0-9][a-zA-Z0-9\-]{0,49}\.)+[a-zA-Z]{2,4})\b";
            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value.ToString());
            }
        }
    }
}