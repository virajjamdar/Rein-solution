using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject
{
    class Prime1to10
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("Prime Number Between 1 To 10");

            for(int i=1;i<10;i++)
            {
                count = 0;
                if(i>0)
                {
                    for(int j=2;j<i;j++)
                    {
                        if(i % j==0)
                        {
                            count = 1;
                            break;
                        }
                    }
                    if(count==0)
                    {
                        Console.Write(i + " ");
                        
                    }
                }
            }
        }
    }
}
