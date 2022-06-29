using System;
using System.Collections.Generic;
using System.Text;

namespace project2
{
    class Adsymbol
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Enter char");
            ch = Console.ReadLine()[0];

            if (ch >= 'A' && ch <= 'Z' || ch>='a' && ch <='z')
            {
                Console.WriteLine("It is Alphabate");

            }

            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("It is digit");
            }

            else
            {
                Console.WriteLine("It is symbol");
            }

        }
    }
}
