using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01sayHello
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a method that asks the user for his name and prints “Hello, <name>” 
             * (for example, “Hello, Peter!”). Write a program to test this method.
             */

            //get user name
            Console.WriteLine("Please enter your name:");
            string userName = Console.ReadLine();
            Console.WriteLine();
            SayHello(userName);

        }

        static void SayHello (string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
