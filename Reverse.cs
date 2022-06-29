using System;
using System.Collections.Generic;
using System.Text;

namespace project2
{
    class Reverse

    {
        static void Main(string[] args)
        {
            
                for (int i = 1; i <= 4; i++)
                {
                    Console.WriteLine();
                    for (int j = 4; j >= i; j--)
                    {
                        Console.Write(j);
                    }
                }

            
        }
    }
}
