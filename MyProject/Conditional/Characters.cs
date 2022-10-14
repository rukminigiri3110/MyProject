using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Conditional
{
    class Characters
    {
        static void Main(String[]args)
        {
            Console.WriteLine("Enter Character = ");
            char ch = char.Parse(Console.ReadLine());
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'z'))
            {
                Console.WriteLine("Character is Alphabet");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("Character is Digit ");
            }
            else
            {
                Console.WriteLine("Character is Special Character ");
            }
        }
    }
}
