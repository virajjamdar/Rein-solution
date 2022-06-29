using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    class @operator
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 2;

            int x;
            x= ++a + ++b;
            Console.WriteLine("x=" + x);

            x = a-- + b++;
            Console.WriteLine("x=" + x);

            x = a++ + --b + a;
            Console.WriteLine("x=" + x); 

            x = --b - b - a--;
            Console.WriteLine("x=" + x);

            x = ++a - ++b + a;
            Console.WriteLine("x=" + x);
        }
    }
}
