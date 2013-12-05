using System.IO;
using System;
using System.Globalization;
//Write a program that reads two dates in the format: day.month.yearand calculates the number of days between them. Example:
//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2004
//Distance: 4 days
class Program
{
    static void Main()
    {
        string firstDate = "22.02.2013";
        string secondDate = "05.03.2013";
        string format = "dd.MM.yyyy";
        DateTime d1 = DateTime.ParseExact(firstDate, format, CultureInfo.InvariantCulture);
        DateTime d2 = DateTime.ParseExact(secondDate, format, CultureInfo.InvariantCulture);
        Console.WriteLine(d2.Subtract(d1).Days);
    }
}