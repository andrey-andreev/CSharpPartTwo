using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//You are given a text. Write a program that changes the text in all regions surrounded by 
//the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. Example:
//We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
//The expected result:
//We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

namespace _05ChangeToUpcase
{
    class ChangeToUpcase
    {
        static void Main(string[] args)
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

            int searchingtIndex = 0;
            string openingTag = "<upcase>";
            string closingTag = "</upcase>";
            while (text.IndexOf(openingTag, searchingtIndex) >= 0)
            {
                int startIndex = text.IndexOf(openingTag, searchingtIndex) + openingTag.Length;
                int length = text.IndexOf(closingTag, searchingtIndex) - startIndex;
                string word = text.Substring(startIndex, length);
                string tagWord = openingTag + word + closingTag;
                text = text.Replace(tagWord, word.ToUpper());
            }
            Console.WriteLine(text);
        }
    }
}
