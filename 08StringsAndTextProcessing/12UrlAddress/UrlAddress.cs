using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//Write a program that parses an URL address given in the format:
//[protocol]://[server]/[resource]
//and extracts from it the [protocol], [server] and [resource] elements. For example 
//from the URL http://www.devbg.org/forum/index.php the following information 
//should be extracted:
//[protocol] = "http"
//[server] = "www.devbg.org"
//[resource] = "/forum/index.php"

namespace _12UrlAddress
{
    class UrlAddress
    {
        static void Main(string[] args)
        {
            string urlAddress = "http://www.devbg.org/forum/index.php";
            string pattern = @"^(\w*)://(\S+?)\/(\S+)$";
            Match m = Regex.Match(urlAddress, pattern);
            Console.WriteLine(m.Groups[1]);
            Console.WriteLine(m.Groups[2]);
            Console.WriteLine(m.Groups[3]);
        }
    }
}
