using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject
{
    class Pattern2Darray
    {
        static void Main(string[] args)
        {
            int[,] a = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 3, 5, 3, 2 }, { 4, 6, 1, 2 } };
            for(int i = 0;i<a.GetLength(0); i++)
            for(int j=0;j<a.GetLength(1);j++)
            {
                if(i == 0 || j == 0 || i == a.GetUpperBound(0)||j==a.GetUpperBound(1))
                        {
                            Console.Write(a[i, j] + " ");

                        }
                else
                        {
                            Console.Write(" ");
                        }
            }
            Console.WriteLine();
        }
    }
}
