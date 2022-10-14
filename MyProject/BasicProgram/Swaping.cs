using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.BasicProgram
{
    class Swaping
    {
        static void Main(string[]args)
        {
            int A = 20, B = 60;
            Console.WriteLine("Before a swap of Value A=" + A + "B=" + B );
            A = A + B;
            B = A - B;
            A = A - B;
            Console.WriteLine("After a swap of Value A=" + A + "B=" + B );
        }
    }
}
