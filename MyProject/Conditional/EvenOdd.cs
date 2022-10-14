using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Conditional
{
    class EvenOdd
    {
        static void Main(string[]args)
        {
            int num;
            Console.WriteLine("Enter a Number=");
            num = int.Parse(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("Enter a Number is Even:");
            }
            else
            {
                Console.WriteLine("Enter a Number is Odd:");
            }
        }
    }

    class Even1
    {
        static void Main(String[]args)
        {
            Console.WriteLine("Enter a Number=");
            int num = int.Parse(Console.ReadLine());
            
            while(num>0)
            {
                int digit = num % 10;
                num = num / 10;
                int rem = digit % 2;
            }
            Console.WriteLine("Even digits =");
        }
    }
}
