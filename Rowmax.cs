using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject
{
    class Rowmax
    {
        static void Main(string[] args)
        {
            int[,] a = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i =0; i < a.GetLength(0);i++)
            {
                int max = a[i, 0];
                for (int j = 0; j < a.GetLength(1);j++)
                {
                    if (max < a[i,j])
                    {
                        max = a[i, j];
                    }
                }
                Console.WriteLine("max=" + max);
            }
        }
    }
}
