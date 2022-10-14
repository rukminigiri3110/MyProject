using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BasicProgram
{
    class Meter
    {
        static void Main(String[]args)
        {
            double cm, meter, km;
            cm = 1000;
            meter = cm / 100.0;
            km = cm / 100000.0;
            Console.WriteLine("Enter Length in Centimeter=" + cm);
            Console.WriteLine("Length in Meter=" + meter);
            Console.WriteLine("Length in Kilometer=" + km);
        }
    }
}
