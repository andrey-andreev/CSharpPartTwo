using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
Write a program that extracts from given HTML file its title (if available), 
and its body text without the HTML tags. Example:
 <html>
  <head><title>News</title></head>
  <body><p><a href="http://academy.telerik.com">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skillful .NET software engineers.</p></body>
</html>
 */

 

namespace ConsoleApplication1
{
    class ExtractTextFromHTML
    {
        static void Main(string[] args)
        {
            string htmlCode = @"<html>
<head><title>News</title></head>
<body><p><a href=""http://academy.telerik.com"">Telerik
Academy</a>aims to provide free real-world practical
training for young people who want to turn into
skillful .NET software engineers.</p></body>
</html>";

            bool whetherPrint = false;
            for (int ch = 0; ch < htmlCode.Length; ch++)
            {
                char currentChar = htmlCode[ch];
                if (currentChar == '<')
                {
                    whetherPrint = false;
                }
                if (currentChar == '>')
                {
                    whetherPrint = true;
                }
                if ((whetherPrint && currentChar != '<') && (whetherPrint && currentChar != '>'))
                {
                    Console.Write(currentChar);
                }
            }
            Console.WriteLine();
        }
    }
}
