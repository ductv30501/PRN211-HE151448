using System;

namespace DemoRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            carrecord car = new carrecord { make = "toyota", name = "altis", year = 2019 };
            car.display();
            carrecord car2 = car with { year = 2010 };
            car2.display();
            carrecord car3 = new carrecord();
            car3.display();
            Console.ReadLine();
        }
    }
}
