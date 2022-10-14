using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Conditional
{
    class Age
    {
        static void Main(String[]args)
        {
            Console.WriteLine("Enter Your Age =");
             int Reshma = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Friends age=");
            int Pooja = int.Parse(Console.ReadLine());
            if(Reshma>Pooja)
            {
                Console.WriteLine("Hii");
            }
            if(Pooja>Reshma)
            {
                Console.WriteLine("Good Morning");
            }
            else
            {
                Console.WriteLine("How are you?");
            }

        }
    }
}
