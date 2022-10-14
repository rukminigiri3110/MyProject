using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.OOPS
{
    class Box
    {
        public int Height;
        public int Width;
        public int Length;
        public int area;

        static void Main(String[] args)
        {
            Box Box = new Box();
            Box.Height = 22;
            Box.Width = 25;
            Box.Length = 20;
            Box.area = Box.Width+Box.Height+Box.Length;
            Console.WriteLine("Area of Box = "+Box.area);
        }
    }
}
