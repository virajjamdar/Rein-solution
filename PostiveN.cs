using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    class PostiveN
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter value for number");
            num = Convert.ToInt32(Console.ReadLine());


            if(num>0)
            {
                Console.WriteLine("number is +ve");

            }
            else if(num<0)
            { 
                Console.WriteLine("number is -ve");

            }
            else
            {
                Console.WriteLine("zero");
            }
        }
    }
}
