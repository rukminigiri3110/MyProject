using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Conditional
{
    class LeapYear
    {
        static void Main(String[]args)
        {
            int Year;
            Console.WriteLine("Enter the Year :");
            Year = Convert.ToInt32(Console.ReadLine());
            if(Year%4==0)
            {
                Console.WriteLine(+Year + "is a Leap Year");
            }
            else
            {
                Console.WriteLine(+Year + "is Not a Leap Year");
            }

        }
    }
}
