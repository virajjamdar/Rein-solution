using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject
{
    static class Myclass
    {

        public static int x = 10;
        
        static Myclass()
        {
            Console.WriteLine("This is static constructor");
        }
           

        public static void read()
        {

            Console.WriteLine("HI");
        }
    }
   class Static
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Myclass.x);
            Myclass.read();
        }
    }
}
