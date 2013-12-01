using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// You are given a sequence of positive integer values written into a string, separated 
// by spaces. Write a function that reads these values from given string and calculates 
// their sum. Example:	string = "43 68 9 23 318" -> result = 461
class StringSequenceSum
{
    static void Main(string[] args)
    {
        int sum = 0;
        string str = "43 68 9 23 318";
        String[] numbers = str.Split(' ');
        foreach (var num in numbers)
        {
            int temp = int.Parse(num);
            sum += temp;
        }
        Console.WriteLine("The sum of the string \"{0}\" is {1}.",str, sum);
    }
}

