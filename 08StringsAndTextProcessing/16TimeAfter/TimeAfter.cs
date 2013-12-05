using System.IO;
using System;
using System.Globalization;
//Write a program that reads a date and time given in the format: day.month.year hour:minute:secondand prints the date and time 
//after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
class Program
{
    static void Main()
    {
        string givenDate = "22.02.2012 6:40:00";
        string format = "dd.MM.yyyy H:mm:ss";
        CultureInfo ci = CultureInfo.CreateSpecificCulture("bg-BG"); //new CultureInfo("bg-BG")
        DateTime parsedDate = DateTime.ParseExact(givenDate, format, ci);
        TimeSpan duration = new System.TimeSpan(6, 30, 0);
        parsedDate = parsedDate.Add(duration);
        Console.WriteLine("{0}  {1}", parsedDate, parsedDate.ToString("dddd", ci));
    }
}