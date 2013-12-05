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
            string pattern = @"(?:<upcase>)(.*?)(?:</upcase>)";
            Regex rgx = new Regex(pattern);
            string result = String.Empty;
            //result = Regex.Replace(text, matches, (matches.ToString()).ToUpper());
            foreach (Match match in rgx.Matches(text))
            {
                result = Regex.Replace(text, match.Value, (match.ToString()).ToUpper());
            }
            Console.WriteLine(result);
        }
    }
}
