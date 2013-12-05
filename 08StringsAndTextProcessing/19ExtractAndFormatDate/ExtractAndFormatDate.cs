using System.IO;
using System;
using System.Text.RegularExpressions;
using System.Globalization;
//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
//Display them in the standard date format for Canada.

namespace _19ExtractAndFormatDate
{
    class ExtractAndFormatDate
    {
        static void Main()
        {
            string text = "12.10.2001 sdhfgdfghdf 25.05.2011 fdg";
            string pattern = @"\b(\d{1,2}\.\d{1,2}\.\d{4})\b";
            string format = "dd.MM.yyyy";
            CultureInfo ci = CultureInfo.InvariantCulture;
            foreach (Match m in Regex.Matches(text, pattern))
            {
                DateTime dt = DateTime.ParseExact(m.Value, format, ci);
                Console.WriteLine(dt.ToString(CultureInfo.GetCultureInfo("en-CA")));
            }
        }
    }
}
