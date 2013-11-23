using System;




namespace _02compareTwoArraysElementByElement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads two arrays from the 
            // console and compares them element by element.

            // enter the lenght of the two arrays
            Console.WriteLine("Please enter the length of the two arrays:");
            int n = int.Parse(Console.ReadLine());

            bool isEqual = true;

            // initialize the two arrays
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            // declare the two arrays
            for (int index = 0; index < n; index++)
            {
	            Console.WriteLine("Enter the value of the element {0} of first array:", index);
	            arr1[index] = int.Parse(Console.ReadLine());
	            Console.WriteLine("Enter the value of the element {0} of second array:", index);
	            arr2[index] = int.Parse(Console.ReadLine());
            }

            // Compare the two arrays
            for (int index = 0; index < n; index++)
            {
	            if (arr1[index] != arr2[index])
	            {
		            isEqual = false;
		            break;
	            }
            }
            //print the result
            if (isEqual)
            {
                Console.WriteLine("The two arrays are equal.");
            }
            else
            {
                Console.WriteLine("The two arrays aren't equal.");
            }
            
        }
    }
}
