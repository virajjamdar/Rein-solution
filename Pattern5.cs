﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject
{
    class Pattern5
    {
        static void Main(string[] args)
        {
            int n = 3;
            int z = 1;

            for(int i=1;i<=n;i++)
            {
                for(int j=n-1;j>=i;j--)
                {
                    Console.Write(" ");
                }

                for(int k=1;k<=z;k++)
                {
                    Console.Write(z);
                }
                z = z + 2;
                Console.WriteLine();
            }
        }
    }
}
