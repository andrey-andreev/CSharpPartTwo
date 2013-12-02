using System;
using System.IO;
using System.Security;
// Write a program that enters file name along with its full file path 
// (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the 
// console. Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure 
// to catch all possible exceptions and print user-friendly error messages.

class ReadFile
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Please enter the full path of the file you want to read from.");
            string path = Console.ReadLine();
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The path is invalid.");
        }

        catch (ArgumentNullException)
        {
            Console.WriteLine("The path is empty.");
        }
         catch (ArgumentException)
        {
            Console.WriteLine("The path is with zero-lenght, contains only white space or have one more invalid character.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The path ot the name of the file is too long");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The path is not found");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The path is in invalid format.");
        }
        catch (SecurityException)
        {
            Console.WriteLine("You don't have a permisson to openr this file.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("There are few possible reasons for the problem:");
            Console.WriteLine("- The file is read-only.");
            Console.WriteLine("- Your platform dosn't support this operation.");
            Console.WriteLine("- The path is wrong.");
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
        

    }
}

