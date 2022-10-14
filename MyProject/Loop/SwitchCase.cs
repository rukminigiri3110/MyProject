using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class SwitchCase
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a 1st Number=");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a 2st Number=");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("1.Addition\n2.Subsraction\n3.Multiplication\n4.Division");
            Console.WriteLine("Enter the choice For given Menu");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Addition=" + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("Substraction=" + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("Multipication=" + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine("Division=" + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }

    class DayName
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a Choice=");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        }
    }

    class Area
    {
        static void Main(String[] args)
        {

            Console.WriteLine("1.Area of Triangle\n2.Area of Rectangle\n3.Area of square\n4.area of circle");
            Console.WriteLine("Enter the choice");
            char choice = Convert.ToChar(Console.ReadLine());

            switch (choice)
            {
                case '1':
                    Console.Write("enter the base:");
                    double Base = Convert.ToDouble(Console.ReadLine());
                    Console.Write("enter the Height:");
                    double Height = Convert.ToDouble(Console.ReadLine());

                    double Area = (Base * Height) / 2;
                    Console.Write("area of a triangle = " + Area);
                    break;

                case '2':

                    Console.WriteLine("enter the length of a rectangle: ");
                    int Length = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the breadth of a rectangle: ");
                    int Breadth = Convert.ToInt32(Console.ReadLine());
                    double area = Length * Breadth;
                    Console.WriteLine(area);
                    break;

                case '3':
                    float PI = 3.14f;
                    Console.Write("Enter Radius: ");
                    double Radious = Convert.ToDouble(Console.ReadLine());
                    double areaofcircle = PI * Radious * Radious;
                    Console.WriteLine("Area of circle: " + areaofcircle);
                    break;

                case '4':
                    Console.WriteLine("Enter the Side of Square: ");
                    int Side = Convert.ToInt32(Console.ReadLine());
                    int Areaofsquare = Side * Side;
                    Console.WriteLine(Areaofsquare);
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }

        }

    }
}