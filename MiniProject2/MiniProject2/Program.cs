using System;

namespace MiniProject2
{

    class Program
    {

        static void Main(string[] args)
        {
            //create couple of objects for the class and perform operations
            Bicycle a = new Bicycle();
            Bicycle b = new Bicycle(2,2);
            Bicycle c = new Bicycle(3,5);

            a.increaseSpeed();
            b.decreaseSpeed();
            c.increaseSpeed();

            a.gearDown();
            b.gearUp();
            c.gearDown();

            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(c.ToString());
        }
    }
}