using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    class Operator1
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 2;
            int c = 2;
            int x;

            x = a++ + b++ + c++;
            Console.WriteLine("x="+x+":"+"a="+a+"b="+b+"c="+c);

            x = ++a + ++b + ++c;
            Console.WriteLine(x+":"+""+a+""+b+""+c);

            x = ++a - ++b - ++c;
            Console.WriteLine(x+":"+""+a+""+b+""+c);

            x = --a - b++ - c--;
            Console.WriteLine(x+":"+""+a+""+b+""+c);

            x = ++c - a - --b + a--;
            Console.WriteLine(x+":"+""+a+""+b+""+c);




        }
    }
}
