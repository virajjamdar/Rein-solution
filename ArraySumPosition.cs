using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject
{
    class ArraySumPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter Array size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            int sum = 0;
            Console.WriteLine("enter array element");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0;i<a.Length;i++)
            {
                if(a[i]%2==0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("sum of even position=" + sum);
        }
    }
}
