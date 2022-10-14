using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Conditional
{
    class DivisibleNo
    {
        static void Main(String[]args)
        {
            int num;
            num = 9;
            Console.WriteLine("Number=" + num);

            if(num%3==0 && num%5==0)
            {
                Console.WriteLine("Divisible by 3 and 5");
            }
            else
            {
                Console.WriteLine("Not Divisible by 3 and 5");
            }

        }
    }

    class DivisibleNo2
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter Your Number =");
            int num = int.Parse(Console.ReadLine());

            if (num % 5 == 0 && num % 11 == 0)
            {
                Console.WriteLine("Divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine("Not Divisible by 5 and 11");
            }

        }
    }
}
