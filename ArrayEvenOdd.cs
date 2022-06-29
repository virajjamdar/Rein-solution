using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject
{
    class ArrayEvenOdd
    {
        static void Main(string[] args)
        {
            int[] a = { 6, 7, 3, 4, 1, 2, 5, 9 };
            Console.WriteLine("Even number=");
            for (int i = 0;i<a.Length;i++)
            {
                if (a[i]%2==0)
                {
                    Console.WriteLine(a[i]);
                }
            }
            Console.WriteLine("Odd number=");
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]%2!=0)
                {
                    Console.WriteLine(a[i]);
                }
            }
            
        }
    }
}
