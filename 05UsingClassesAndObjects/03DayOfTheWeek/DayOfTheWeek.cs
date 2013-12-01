using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that prints to the console which day of the week is today. Use System.DateTime.
class DayOfTheWeek
{
    static void Main(string[] args)
    {
        DateTime date = DateTime.Now;
        string weekDay = date.DayOfWeek.ToString();
        Console.WriteLine("Today is {0}.", weekDay);
    }
}

