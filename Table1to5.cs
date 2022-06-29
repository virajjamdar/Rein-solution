using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject
{
    class Table1to5
    {
        static void Main(string[] args)
        {
            int n = 5;

            for (int i= 1;i <= n; i++)
            {
                for(int j=1;j<=10;j++)
                {
                    int res = i * j;
                    Console.Write("\t"+res);
                }
                Console.WriteLine("\n");
                Console.WriteLine();

            }

        }
    }
}
