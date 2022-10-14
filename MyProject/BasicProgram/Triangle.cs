using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BasicProgram
{
    class Triangle
    {
        static void Main(String[] args)
        {
            int Base = 10;
            int Height = 15;
            int Area = (Base * Height)/2;
            Console.WriteLine("Base of Triangle=" + Base);
            Console.WriteLine("Height Of Triangle=" + Height);
            Console.WriteLine("Area of Triangle=" + Area);
        }
    }
}
