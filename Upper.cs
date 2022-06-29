using System;
using System.Collections.Generic;
using System.Text;

namespace project2
{
    class Upper
    {
        static void Main(string[] args)
        {
            char ch,res;

            Console.WriteLine("Enter Character:");
            ch = Console.ReadLine()[0];

            if(ch>='A' && ch<='Z')
            {
                res =(char)(ch + 32);
                Console.WriteLine("Lower Case="+res);
            }
            else if(ch>='a' && ch<='z')
            {
                res = (char)(ch - 32);
                Console.WriteLine("Upper Case="+res);
            }
            else
            {
                Console.WriteLine("It Is Not Alphabet");
            }
        }
    }
}
