using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BasicProgram
{
    class EquilateralTriangle
    {
        static void Main(String[]args)
        {
            float Side;
            double Area;
            Side = 20;
            Console.WriteLine("Enter a Side of Equilateral Triangle=" + Side);
            Area = (1.73 * Side * Side)/ 4;
            Console.WriteLine("Area Of Equilateral Triangle =" + Area);
        }
    }
}
