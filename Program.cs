using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_Dr.Samir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n;
            //bool isPrime;
            //int x;
            //do
            //{
            //    Console.Write("Enter a frist number: ");
            //    x=Int32.Parse(Console.ReadLine());
            //    Console.Write("Enter a second number: ");
            //    n = Int32.Parse(Console.ReadLine());
            //}
            //while (n <= 1 || x<=1);
            //Console.WriteLine("All prime numbers between two numbers is " + n + ": ");
            //for (int i = x; i <= n; i++)
            //{
            //    isPrime = true;
            //    for (int j = 2; j <= i / 2; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime)
            //    {
            //        Console.WriteLine(i + " ");
            //    }
            //}
            Console.WriteLine("enter frist number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number:");
            int y = int.Parse(Console.ReadLine());
            bool isPrime;
            for (int j = x; j <= y; j++)
            {
                isPrime = true;
                for (int i = 2; i <= j/2 ; i++)
                {
                    if (j % i == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.WriteLine(j);
                }
            
            }

        }
    }
}
 
