using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04CountSubstringAppeaраnces
{
    class CountSubstringAppeaраnces
    {
        static void Main(string[] args)
        {
            string str = @"We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string word = "in";
            Console.WriteLine("The result is: " + CountSubstringAppearance(str, word));
        }

        static int CountSubstringAppearance(string str, string word)
        {
            int result = 0;
            for (int index = 0; index < str.Length - word.Length; index++)
            {
                if (str.Substring(index, word.Length).ToLower() == word)
                {
                    result++;
                    index += word.Length - 1;
                }
            }

            return result;
        }
    }
}
