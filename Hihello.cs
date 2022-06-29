using System;
using System.Collections.Generic;
using System.Text;

namespace project2
{
    class Hihello
    {
        static void Main(string[] args)
        {
            int A;

            Console.WriteLine("Enter number=");
            A = Convert.ToInt32(Console.ReadLine());

            if (A <= 3)
            {
                Console.WriteLine("hi");

            }
            else if (A > 3 && A < 10)
            {
                Console.WriteLine("hello");


            }
            else
            {
                Console.WriteLine("HI,HELLO");
            }
        }
    }
}
