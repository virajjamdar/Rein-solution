using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    class Arithmatics
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 10;
            int res;

            Console.WriteLine("Number 1: " + a);
            Console.WriteLine("\nNumber 2: " + b);

            res = a + b;
            Console.WriteLine("\nAddition Is:"+res);

            res = a - b;
            Console.WriteLine("\nSubtraction Is:"+res);

            res = a * b;
            Console.WriteLine("\nMultiplication Is:"+res);

            res = a / b;
            Console.WriteLine("\nDivision Is:"+res);
        }
    }
}
