using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject
{
    class Car
    {
        public String company = "Maruti";

        public void output()
        {
            Console.WriteLine(company);
        }



    }

    class Maruti : Car
    {
        public String car_name="Swift";
        public void show()
        {
            Console.WriteLine(car_name);
        }
    }

    class Swift : Maruti
    {
        public int price = 1000000;

        public void display()
        {
            Console.WriteLine(price);
        }
    }
    class MultilevelDemo
    {
        static void Main(string[] args)
        {
            Swift s = new Swift();
            s.output();
            s.show();
            s.display();
        }
    }
}
