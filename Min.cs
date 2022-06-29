using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject
{
    class Min
    {
        static void Main(string[] args)
        {
            Char[] ch = { 'a', 'b', 'c', 'd' };
            char min = ch[0];
            for (int i = 0; i< ch.Length;i++)
            {
                if(min>ch[i])
                {
                    min = ch[i];
                }
            }
            Console.WriteLine("min is=" + min);
        }
    }
}
