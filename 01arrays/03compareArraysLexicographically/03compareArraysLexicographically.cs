using System;


namespace _03compareArraysLexicographically
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that compares two char arrays 
            // lexicographically (letter by letter).

            // "При лексикографската наредба символите се сравняват един по един
            // като се започва от най-левия. При несъвпадащи символи по-рано е
            // масивът, чийто текущ символ е по-рано в азбуката. При съвпадение
            // се продължава със следващия символ вдясно. Ако се стигне до края
            // на единия масив, по-краткият е лексикографски по-рано. Ако всички
            // съответни символи от двата масива съвпаднат, то масивите са
            // еднакви и никой о тях не е по-рано в лексикографската наредба."

            // get the array's length
            Console.WriteLine("Enter the first array's length:");
            int firstArrLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second array's length:");
            int secondArrLength = int.Parse(Console.ReadLine());
            //
            int shorterLength = Math.Min(firstArrLength, secondArrLength);
            bool areEqual = firstArrLength == secondArrLength;
            bool firstArrIsShorter = firstArrLength < secondArrLength;

            // declare the two arrays
            char[] firstArr = new char[firstArrLength];
            char[] secondArr = new char[secondArrLength];

            // initialize the two arrays
            Console.WriteLine("Enter the elements of the first array.");
            for (int index = 0; index < firstArrLength; index++)
            {
	            firstArr[index] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the elements of the second array.");
            for (int index = 0; index < secondArrLength; index++)
            {
	            secondArr[index] = char.Parse(Console.ReadLine());
            }

            // compare the two arrays char by char
            for (int index = 0; index < shorterLength; index++)
            {
                // the case when the arrays aren't equal
                if (firstArr[index] != secondArr[index])
                {
                    if (firstArr[index] < secondArr[index])
                    {
                        Console.WriteLine("In lexicographical order the first array is first.");
                    }
                    else
                    {
                        Console.WriteLine("In lexicographical order the second array is first.");
                    }
                    break;
                }
                else if (firstArr[index] == secondArr[index])
                {
                    // the equal case
                    if (index == shorterLength - 1 && areEqual)
                    {
                        Console.WriteLine("In lexicographical order the two arrays are equal.");
                        continue;
                    }
                    else if (index == shorterLength - 1 && firstArrIsShorter)
                    {
                        Console.WriteLine("In lexicographical order the first array is first.");
                        continue;
                    }
                    else if (index == shorterLength - 1 && !firstArrIsShorter)
                    {
                        Console.WriteLine("In lexicographical order the second array is first.");
                    }
                }
                
            }

        }
    }
}
