using System;



namespace _01multiplyEachElementBy5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that allocates array of 20 integers and initializes each 
            // element by its index multiplied by 5. Print the obtained array on the console.

            int[] arr = new int[20];
            for (int i = 0; i < 20; i++)
            {
	            arr[i] = i * 5;
            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Element {0}: {1}", i, arr[i]);
            }
        }
    }
}
