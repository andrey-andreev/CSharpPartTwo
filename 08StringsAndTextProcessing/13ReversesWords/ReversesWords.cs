using System;
using System.Text;
using System.Text.RegularExpressions;


class ReversesWords
{
    static void Main()
    {
        string text = @"C# is not C++, not PHP and not Delphi!";
        Console.WriteLine(text);
        string pattern = @"[\.\s,\?!]+";
        string patternWords = @"[^\.\s,\?!]+";
        MatchCollection words = new Regex(pattern).Matches(text);
        MatchCollection punctuation = new Regex(patternWords).Matches(text);
        StringBuilder newText = new StringBuilder(words.Count + punctuation.Count);
        for (int index = 0; index < words.Count; index++)
        {
            newText.Append(punctuation[words.Count - 1 - index].Value);
            newText.Append(words[index]);
            
        }
        Console.WriteLine(newText.ToString());
    }
}