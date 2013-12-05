using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a program to check if in a given expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d).
// Example of incorrect expression: )(a+b)).

namespace _03CheckBrackets
{
    class CheckBrackets
    {
        static void Main(string[] args)
        {
            string str = "((a+b)/5-d)";
            //string str = ")(a+b))";
            CheckBracketsWhetherPlacedCorrectly(str);
        }

        static void CheckBracketsWhetherPlacedCorrectly(string str)
    {
        int bracketsCount = 0;
        //check for start or end with wrong brackets
        if (str.IndexOf('(') > str.IndexOf(')') || str.LastIndexOf('(') > str.LastIndexOf(')'))
        {
            Console.WriteLine("The brackets aren't placed correctly.");
        }
        else
        {
            for (int index = 0; index < str.Length; index++)
            {
                char symbol = str[index];
                if (symbol == '(')
                {
                    bracketsCount++;
                }
                else if (symbol == ')')
                {
                    bracketsCount--;
                }
                
            }
            if (bracketsCount == 0)
            {
                Console.WriteLine("The brackets are placed correctly.");
            }
            else
            {
                Console.WriteLine("The brackets aren't placed correctly.");
            }
        }
    }
    }
}
