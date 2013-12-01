using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write methods that calculate the surface of a triangle by given:
// Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.
class TriangleSurface
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose with which parameters want to calculate the triangle surface:");
        Console.WriteLine("1) for calculate with a side and an altitude to it;");
        Console.WriteLine("2) for calculate with three sides;");
        Console.WriteLine("3) for calculate with two sides and an angle(in radians) between them.");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                CalcBySideAndAltitude();
                break;
            case 2:
                CalcByThreeSides();
                break;
            case 3:
                CalcByTwoSidesAndAngle();
                break;
            default:
                break;
        }
    }

    // Method that calculate the surface of a triangle by given side and an altitude to it. 
    // Formula -> s=1/2*b*h
    static void CalcBySideAndAltitude()
    {
        Console.WriteLine("Enter the triangle's side:");
        double side = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the triangle's height:");
        double h = double.Parse(Console.ReadLine());
        double s = 0;
        s = 0.5 * side * h;
        Console.WriteLine("The surface of the triangle is {0}.", s);
    }
    // Method that calculate the surface of a triangle by given three sides. 
    // Formula -> s=sqrt(s(s-a)(s-b)(s-c))
    static void CalcByThreeSides()
    {
        Console.WriteLine("Enter the triangle's side A:");
        double sideA = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the triangle's side B:");
        double sideB = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the triangle's side C:");
        double sideC = double.Parse(Console.ReadLine());
        double s = 0.5 * (sideA + sideB + sideC);
        s = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        // check whether one of the sides is bigger than the sum of the other two sides.
        double biggest = Math.Max(sideA, Math.Max(sideB, sideC));
        bool isBigger = biggest >= 2 * s - biggest;
        if (isBigger)
        {
            Console.WriteLine("One of the sides you entered is bigger then then the sum of the other two sides.");
        }
        else
        {
            Console.WriteLine("The surface of the triangle is {0}.", s);
        }
        
        
    }
    // Method that calculate the surface of a triangle by given two sides and an angle(in radians) between them. 
    // Formula -> s=1/2*a*b*sin(C)
    static void CalcByTwoSidesAndAngle()
    {
        Console.WriteLine("Enter the triangle's side A:");
        double sideA = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the triangle's side B:");
        double sideB = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the angle between side A and side B (-1 < angle < 1):");
        double angle = double.Parse(Console.ReadLine());
        double s = 0;
        s = 0.5 * sideA * sideB * Math.Asin(angle);
        Console.WriteLine("The surface of the triangle is {0}.", s);
    }
}

