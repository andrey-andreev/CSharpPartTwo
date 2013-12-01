using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a method that calculates the number of workdays between today and given date, 
// passed as parameter. Consider that workdays are all days from Monday to Friday except 
// a fixed list of public holidays specified preliminary as array.

class WorkDays
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the end date for the period in YYYY/MM/DD format:");
        DateTime endDate = DateTime.Parse(Console.ReadLine());
        
        
        Console.WriteLine(WorkDaysCount(endDate));

    }

    static int WorkDaysCount(DateTime date)
    {
        DateTime today = DateTime.Today;
        int workDays = Math.Abs((date - today).Days);  // !!!!!!!!!!!!!!!!!!!!!!!!
        DateTime startDate = today;
        DateTime endDate = date;
        if (today > date)
        {
            startDate = date;
            endDate = today;
        }
        workDays -= CountHolidaysDays(startDate, endDate);
        workDays -= CountWeekendDays(startDate, endDate);
        workDays += CountWorkOffDays(startDate, endDate);
        return workDays;
    }
    static int CountWeekendDays(DateTime startDate, DateTime endDate)
    {
        int count = 0;
        DateTime compareDate = startDate;
        int length = Math.Abs((startDate - endDate).Days);
        while (compareDate <= endDate)
        {
            if (compareDate.DayOfWeek == DayOfWeek.Sunday || compareDate.DayOfWeek == DayOfWeek.Saturday)
            {
                count++;
            }
            compareDate = compareDate.AddDays(1);
        }
        return count;
    }

    static int CountHolidaysDays(DateTime startDate, DateTime endDate)
    {
        //!!!!!!!!!!!!
        int count = 0;
        DateTime[] holidays = 
        {
            new DateTime(2013,01,01),
            new DateTime(2013,05,01),
            new DateTime(2013,05,02),
            new DateTime(2013,05,03),
            new DateTime(2013,05,06),
            new DateTime(2013,09,06),
            new DateTime(2013,12,24),
            new DateTime(2013,12,25),
            new DateTime(2013,12,26),
            new DateTime(2013,12,21)
        };
        foreach (var holiday in holidays)
        {
            if (startDate <= holiday && holiday <= endDate)
            {
                count++;
            }
        }

        return count;
    }

    static int CountWorkOffDays(DateTime startDate, DateTime endDate)
    {
        //!!!!!!!!!!!!
        int count = 0;
        DateTime[] workOffDays = 
        {
            new DateTime(2013,05,18),
            new DateTime(2013,12,14)
        };
        foreach (var workOffDay in workOffDays)
        {
            if (startDate <= workOffDay && workOffDay <= endDate)
            {
                count++;
            }
        }

        return count;
    }
}
//http://forums.academy.telerik.com/54084/c%23-using-classes-and-objects-5-%D0%B7%D0%B0%D0%B4%D0%B0%D1%87%D0%B0
