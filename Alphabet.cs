using System;
using System.Collections.Generic;
using System.Text;

namespace project2
{
    class Alphabet
    {
        static void Main(string[] args)
        {
            for(char i='A';i<='D';i++)
            {
                Console.WriteLine();
                for(char j='D';j>=i;j--)
                {
                    Console.Write(j);

                }
            }
        }
    }
}
