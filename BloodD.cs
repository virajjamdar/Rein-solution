using System;
using System.Collections.Generic;
using System.Text;

namespace project2
{
    class BloodD
    {
        static void Main(string[] args)
        {
            int age, wt;

            Console.WriteLine("Enter age=");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter weight=");
            wt = Convert.ToInt32(Console.ReadLine());

            if(age>=18)
            {
                if(wt>50)
                {
                    Console.WriteLine("Eligible For Blood Donation");
                }
                else
                {
                    Console.WriteLine("Weight Is Less Than 50");
                }
            }
            else
            {
                Console.WriteLine("Not Eligible For Blood Donation");
            }

        }
    }
}
