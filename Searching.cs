using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject
{
    class Searching
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 8, 3, 9, 2 };
            Console.WriteLine("enter element for searching");
            int num = Convert.ToInt32(Console.ReadLine());
            bool ispresent = false;
            for(int i=0;i<a.Length;i++)
            {
                if (num == a[i])
                {
                    ispresent = true;
                    break;
                }
            }
            if (ispresent == true)
            {
                Console.WriteLine("number is present");
            }
            else
            {
                Console.WriteLine("number is not present");
            }
        }
    }
}
