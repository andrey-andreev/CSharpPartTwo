using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05and06IsBiggerThanNeighbors
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Problem 5
             * Write a method that checks if the element at given position in given 
             * array of integers is bigger than its two neighbors (when such exist).
             */
            Console.WriteLine("Promlem 5 \n");

            //try to change array's element values to test 
            //int[] myArr = {-30, 2, 10, -54, -23, 79, 66, 87, -57};
            int[] myArr = { -30, 2, 5, 7, 11, 79, 111, 123, 143 };

            //print the array and the number
            Console.Write("This is the array {");
            for (int index = 0; index < myArr.Length; index++)
            {
                Console.Write(myArr[index]);
                if (index < myArr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("}");
            Console.Write("Please enter the index number between 0 and {0}: ", myArr.Length - 1);
            int numIndex = int.Parse(Console.ReadLine());
            

            //using the method
            Console.Write("The number with index {0} ", numIndex);
            if (ComapreToNeighbors(numIndex, myArr))
            {
                Console.Write("is bigger than its neighnors.");
            }
            else
            {
                Console.Write("isn't bigger than its neighbors.");
            }
            Console.WriteLine("\n");

            /*problem 6
             * Write a method that returns the index of the first element in array that is 
             * bigger than its neighbors, or -1, if there’s no such element.
             *    - Use the method from the previous exercise.
             */
            Console.WriteLine("Promlem 6 \n");
            bool IsBiggerThanNeighbors = false;
            int counter = 0;
            int firstBiggerNumIndex = 0;
            while (IsBiggerThanNeighbors == false)
            {
                IsBiggerThanNeighbors = ComapreToNeighbors(counter, myArr);
                if (IsBiggerThanNeighbors)
                {
                    firstBiggerNumIndex = counter;
                }
                counter++;
            }
            if (IsBiggerThanNeighbors)
            {
                Console.WriteLine("First element bigger than its neighbors is {0} with index {1}.", myArr[firstBiggerNumIndex], firstBiggerNumIndex);
            }
            else
            {
                Console.WriteLine("-1");
            }

        }

        static bool ComapreToNeighbors(int numIndex, int[] myArr)
        {
            bool isBigger = false;
            
            //when the number have neighbor only from right
            if (numIndex == 0)
            {
                if (myArr[numIndex] > myArr[numIndex + 1])
                {
                    isBigger = true;
                }
                
            }
            //when the number have neighbor only from left
            else if (numIndex == myArr.Length - 1)
            {
                if (myArr[numIndex] > myArr[numIndex - 1])
                {
                    isBigger = true;    
                }
            }
            //when the number have two neighbors
            else if (myArr[numIndex] > myArr[numIndex - 1] && myArr[numIndex] > myArr[numIndex + 1])
            {
                isBigger = true;
            }

            return isBigger;
        }
    }
}
