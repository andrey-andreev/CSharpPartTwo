using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

/* Write a program that downloads a file from Internet 
 * (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. 
 * Find in Google how to download files in C#. Be sure to catch all exceptions and to 
 * free any used resources in the finally block.
 */

class StoreADownloadedFile
{
    static void Main(string[] args)
    {
        WebClient wc = new WebClient();
        try
        {

            wc.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "../../logo.jpg");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The address parameter is null.");
        }
        catch (WebException)
        {
            Console.WriteLine("- The address is invalid.");
            Console.WriteLine("- or filename is null or empty.");
            Console.WriteLine("- or the file does not exist.");
            Console.WriteLine("- or an error occurred while downloading data.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The method has been called simultaneously on multiple threads.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            wc.Dispose();
        }
    }
}

