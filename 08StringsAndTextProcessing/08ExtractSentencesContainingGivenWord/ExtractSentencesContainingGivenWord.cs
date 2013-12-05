using System;
using System.Text;
using System.Text.RegularExpressions;

//Write a program that extracts from a given text all sentences containing given word.

//Example: The word is "in". The text is:
//We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we 
//are drinking all the day. We will move out of it in 5 days.

//The expected result is:
//We are living in a yellow submarine.
//We will move out of it in 5 days.

//Consider that the sentences are separated by "." and the words – by non-letter symbols.

namespace _08ExtractSentencesContainingGivenWord
{
    class ExtractSentencesContainingGivenWord
    {
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string word = "in";
            Regex rgx = new Regex(@"\s*([^\.]*\b" + word + @"\b.*?\.)");
            MatchCollection matches = rgx.Matches(text);

            foreach (Match sentence in matches)
            {
                Console.WriteLine(sentence.Groups[1]);
            }
        }
    }
}
