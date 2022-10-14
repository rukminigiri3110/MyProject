using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BasicProgram
{
    class PerimeterRectangle
    {
        static void Main(string[]args)
        {
            int Length = 20;
            int Breadth = 10;
            Console.WriteLine("Length of Rectriangle=" + Length);
            Console.WriteLine("Breadth Of Rectriangle=" + Breadth);
            int Perimeter = 2 * (Length + Breadth);
            Console.WriteLine("Perimeter Of Rectangle=" + Perimeter);
        }
    }
}
