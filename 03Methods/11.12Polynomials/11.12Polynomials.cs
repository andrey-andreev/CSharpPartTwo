using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*11
 * Write a method that adds two polynomials. Represent them as arrays of their coefficients 
 * as in the example below:	x2 + 5 = 1x2 + 0x + 5 -> 501
 * 12
 * Extend the program to support also subtraction and multiplication of polynomials.
 */
namespace _11._12Polynomials
{
    class Program
    {
        static void Main()
        {
            //input data
            int[] firstPol = new int[]{1, 2, 5, 0, -6};
            int[] secondPol = new int[]{5, -3, 2, 0};
            Console.WriteLine("First polynomial:");
            PrintPol(firstPol);
            Console.WriteLine("Second polynomial:");
            PrintPol(secondPol);
            Console.WriteLine();
        
            //add polynomials and print the result
            Console.WriteLine("Summation:");
            int[] resultAdd = new int[Math.Max(firstPol.Length, secondPol.Length)];
            AddPolynomials(firstPol, secondPol, resultAdd);
            PrintPol(resultAdd);
        
            //subtract polynomials and print the result
            Console.WriteLine("Subtraction:");
            int[] resultSub = new int[Math.Max(firstPol.Length, secondPol.Length)];
            SubtractPolynomials(firstPol, secondPol, resultSub);
            PrintPol(resultSub);
        
            //multiply polynomials and print the result
            Console.WriteLine("Multiplication:");
            int[] resultMultiply = new int[firstPol.Length + secondPol.Length];
            MultiplyPolynomials(firstPol, secondPol, resultMultiply);
            PrintPol(resultMultiply);
        
        }
        
        static void AddPolynomials(int[] firstPol, int[] secondPol, int[] result)
        {
            int minLength = Math.Min(firstPol.Length, secondPol.Length);
            int maxLength = Math.Max(firstPol.Length, secondPol.Length);
            for (int index = 0; index < minLength ; index++)
            {
                result[index] = firstPol[index] + secondPol[index];
            }
            for (int index = minLength; index < maxLength ; index++)
            {
                if (firstPol.Length != minLength)
                {
                    result[index] = firstPol[index];
                }
                else 
                {
                    result[index] = firstPol[index];
                }
            
            }
        
        }
    
        static void SubtractPolynomials(int[] firstPol, int[] secondPol, int[] result)
        {
            int minLength = Math.Min(firstPol.Length, secondPol.Length);
            int maxLength = Math.Max(firstPol.Length, secondPol.Length);
            for (int index = 0; index < minLength ; index++)
            {
                result[index] = firstPol[index] - secondPol[index];
            }
            for (int index = minLength; index < maxLength ; index++)
            {
                if (firstPol.Length != minLength)
                {
                    result[index] = firstPol[index];
                }
                else 
                {
                    result[index] = secondPol[index];
                }
            
            }
        }
    
        static void MultiplyPolynomials(int[] firstPol, int[] secondPol, int[] result)
        {
            for (int i = 0; i < firstPol.Length; i++)
            {
                for (int j = 0; j < secondPol.Length; j++)
                {
                    int position = i + j;
                    result[position] += (firstPol[i] * secondPol[j]);
                }
            }
        }
    
        static void PrintPol(int[] pol)
        {
            Console.Write("{");
            for (int index = 0; index < pol.Length; index++)
            {
                Console.Write(pol[index]);
                if (index < pol.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("}\n");
        }
    }
}
