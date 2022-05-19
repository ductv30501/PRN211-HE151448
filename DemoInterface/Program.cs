using System;

namespace DemoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.display();
            Ifirst first = obj;
            first.print();
            Isecond second = obj;
            second.print();
            Console.ReadLine();
        }
    }
}
