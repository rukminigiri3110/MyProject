using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Conditional
{
    class PositiveNegative
    {
        static void Main(String[]args)
        {
            int num;
            Console.WriteLine("Enter a Number:");
            num = int.Parse(Console.ReadLine());
            if(num>0)
            {
                Console.WriteLine("Positive Number is:");
            }
            else
            {
                Console.WriteLine("Negative Number is :");
            }
        }
    }
}
