using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*You are given an array of strings. Write a method that sorts the array by the 
 * length of its elements (the number of characters composing them).
 */

namespace _05SortByLength
{
    class Program
    {
        static void Main(string[] args)
        {
            //input test data
            string[] strArr = { "..3", ".......8", "....5", ".2", "...4", "......7", "...4", "1", "....5"};

            //lambda
            Console.WriteLine("Lambda expression");
            foreach (var item in strArr.OrderBy(uStrings => uStrings.Length))
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine("\n");

            //linq
            Console.WriteLine("Linq solution");
            var sortedArr =
                from el in strArr
                orderby el
                select el;
            foreach (var item in sortedArr)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
        }
    }
}
