﻿using System;
using System.Collections.Generic;
using System.Text;

namespace project2
{
    class Pattern1
    {
        static void Main(string[] args)
        {
            int i, j;

            for(i=1;i<=4;i++)
            {
                for (j = 1; j<= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
