using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    class Swapping1
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int temp;

            Console.WriteLine("Values Before Swapping:" + a +b);
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("Values After Swapping:" + a +b);

        }
    }
}
