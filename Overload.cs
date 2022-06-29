using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject
{
    class Overload
    {
        
          void area(float r)
          {
            Console.WriteLine("Area Of Circle:" + 3.14 * r * r);
          }

        void area(float h,float w)
        {
            Console.WriteLine("Area Of Rectangle:" + h * w);
        }

        void area(int s)
        {
            Console.WriteLine("Area Of  Square:" + (2*s * s));
        }

        void area(int h,int b)
        {
            Console.WriteLine("Area Of Triangle:" +(h * b)/2);
        }

        static void Main(string[] args)
        {
            Overload ov = new Overload();
            ov.area(5.5f);
            ov.area(4.5f, 5.3f);
            ov.area(5);
            ov.area(5, 4);
        }
        
    }
}
