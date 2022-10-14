using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class WhileLoop
    {
        static void Main(String[]args)
        {
            int i = 1;
            while(i<=5)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }

    class factorial
    {
        static void Main(String[]args)
        {
            
            Console.WriteLine("Enter a Number");
            int num = int.Parse(Console.ReadLine());
            int i = 1;
            int fact = 1;
            while(i<=num)
            {
                fact = fact * i;
                i++;
            }
            Console.WriteLine("Factorial of" + num + "is" + fact);
        }
    }

    class Palindrome
    {
        static void Main(String[]args)
        {
            Console.WriteLine("Enter a Number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = num;
            while(num>0)
            {
               int r = num % 10;
                sum = sum * 10 + r;
                num = num / 10;
            }
            Console.WriteLine(sum + " " + num);

            num = temp;
            if (temp == num) 
            {
                Console.WriteLine("Number is Palindrome:");
            }
            else
            {
                Console.WriteLine("Number is Not a Palindrome:");
            }
        }
    }

    class Armstrong
    {
        static void Main(String[]args)
        {
            Console.WriteLine("Enter a Number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = num;
            while(num>0)
            {
                int r = num % 10;
                sum = sum + (r * r * r);
                num = num / 10;
            }
            Console.WriteLine(sum+" "+num);

            num = temp;
            if(num==sum)
            {
                Console.WriteLine("Number is Armstrong:");
            }
            else
            {
                Console.WriteLine("Number is Not Armstrong:");
            }

        }
    }

    class Number
    {
        static void Main(String[]args)
        {
            int i = 35;
            while(i<=75)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }

    class DisplayNumber
    {
        static void Main(String[]args)
        {
            int i = 60;
            while(i>=25)
            {
                Console.WriteLine(i);
                i--;
            }
        }
    }

    class MagicNo
    {
        static void Main(String[]args)
        {
            int temp;
            Console.WriteLine("Enter a Number=");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            temp = num;
            //while ()
            {
                sum += temp % 10;
                temp = temp / 10;
            }
            int res = num % sum;
            if (res == 0)
                Console.WriteLine("Harshad Number");
            else
                Console.WriteLine("Not Harshad Number");
        }
    }
}
