using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject
{
    class RowwiseMinElementArray
    {
        static void Main(string[] args)
        {
            int[,] a = { { 11, 42, 3 }, 
                         { 42, 5, 56 }, 
                         {27,98, 9 } };

            for(int i=0;i<a.GetLength(0);i++)
            {
                int min = a[i, 0];
                for (int j=0;j<a.GetLength(1); j++)
                {
                    if (min>a[i,j])
                    {
                        min = a[i, j];
                    }
                }
                Console.WriteLine(min);
            }
        }
    }
}
