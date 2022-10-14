using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BasicProgram
{
    class Rectangle
    {
        static void Main(String[]args)
        {
            int Length = 15;
            int Breadth = 10;
            int Area = Length * Breadth;
            Console.WriteLine("Length Of Rectangle=" + Length);
            Console.WriteLine("Breadth of Rectangle=" + Breadth);
            Console.WriteLine("Area Of Rectangle=" + Area);
        }
    }
}
