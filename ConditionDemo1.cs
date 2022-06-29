using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    class ConditionDemo1
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("enter value for num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value for num2");
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2)
            {
                Console.WriteLine("Max number is =" + num1);
            }
            else
            {
                Console.WriteLine("Max number is=" + num2);
            }
        }
    }
}
