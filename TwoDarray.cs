using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject
{
    class TwoDarray
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            Console.WriteLine("Enter Array Elements");
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("//////////////");
            for(int i=0;i<a.GetLength(0);i++)
            {

            }
        }
    }
}
