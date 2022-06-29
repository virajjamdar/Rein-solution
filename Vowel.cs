using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    class Vowel
    {
        static void Main(string[] args)
        {
            char ch;


            Console.WriteLine("enter char");
            ch = Console.ReadLine()[0];
            if (ch == 'a' || ch=='A' )
            {
                Console.WriteLine("vowel");

            }
            else if (ch == 'e' || ch=='E')
            {
                Console.WriteLine("vowel");
            }
            else if (ch=='i' || ch=='I')
            {
                Console.WriteLine("vowel");
            }
            else if(ch=='o' || ch=='O')
            {
                Console.WriteLine("vowel");
            }
            else if(ch=='u' || ch=='U')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonent");
            }
            
        }
    }
}
