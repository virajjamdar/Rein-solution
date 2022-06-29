using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("number is Even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }

         
        }
    }
}
