﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject
{
    class TrianglePattern
    {
        static void Main(string[] args)
        {
            for (int i=1;i<=4;i++)
            { 
                for (int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
