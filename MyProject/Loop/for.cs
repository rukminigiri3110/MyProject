using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Loop
{
    class @for
    {
             static void Main(String[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    class AlternateNo
    {
        static void Main(String[]args)
        {
            for (int i = 1; i <= 20; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Power
    {
        static void Main(String[]args)
        {
            int basenumber, exponent, i, power;

            // Reading number
            Console.Write("Enter any Base: ");
            basenumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter any Exponent: ");
            exponent = Convert.ToInt32(Console.ReadLine());

            power = 1;
            for (i = 1; i <= exponent; i++)
                power = power * basenumber;


            Console.Write("Power : " + power);

            Console.ReadLine();
        }
    }

    class Factorial
    {
        static void Main(String[]args)
        {
            int i,num,fact=1;

            Console.WriteLine("Enter a Number");
            num = int.Parse(Console.ReadLine());
            for(i=1;i<=num;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of"  + num +  "is"  + fact);
        }
    }

    class sumof10
    {
        static void Main(String[]args)
        {
            int i, sum = 0;
            Console.WriteLine("Enter First 10 Numbers=");
            i = int.Parse(Console.ReadLine());
            for(i=1;i<=10;i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Enter a Sum of Numbers=" + sum);
        }
    }

    class sumofevenno
    {
        static void Main(String[]args)
        {
            int i = 0,num,sum=0;
            Console.WriteLine("Enter a Number = ");
            num= int.Parse(Console.ReadLine());
            for(i=2;i<=num;i+=2)
            {
                sum += i;
            }
            Console.WriteLine("Sum of Even Numbers for 1 to 30 is =" + sum);
        }
    }

    class series1
    {
        static void Main (String[]args)  //1,3,7,5....
        {
           
            int p = 2;
            for(int i=1;i<=50;)
            {
                Console.WriteLine(i);
                i = i + p;
                p = p * 2;
            }
        }
    }

    class ReverseNo
    {
        static void Main(String[] args)
        {
            int n = 12345, reverse = 0, rem;
            Console.WriteLine("Enter a No=");
            n = int.Parse(Console.ReadLine());
            for (; n >= 1;)
            {
                reverse = reverse * 10 + n % 10;
                n = n / 10;
            }
        }
    }

    class Odd
    {
        static void Main(String[]args)
        {
            int i = 0;

            Console.WriteLine("Odd Numbers :");
            for (i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }

    class Reverse
    {
        static void Main(String[]args)
        {
            {
                for (int i = 175; i >= 120; i--)
                    Console.WriteLine(i);

            }
        }
    }

    class AlternateEven
    {
        static void Main(String[]args)
        {
            {
                for (int i = 2; i <= 20; i = i + 4)
                    Console.WriteLine(i);
            }
        }
    }
     class Seies2
    {
        static void Main(String[]args)  //1,8,27,64....
        {
            int n, i;
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                Console.WriteLine(i * i * i + "");
            }
        }
    }

    class Series3
    {
        static void Main(String[] args)   //0,7,26,63....
        {
            int n, i,p;
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                p = i * i * i - 1;
                Console.WriteLine(p);
            }
        }
    }

    class Seies4
    {
        static void Main(String[] args)  //1,4,9,16...
        {
            int n, i;
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(i * i + "");
            }
        }
    }
}
