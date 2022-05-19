using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    class MyClass : Ifirst, Isecond
    {
        public void display()
        {
            Console.WriteLine("this is display in interface Ifirst");
        }

         void Ifirst.print()
        {
            Console.WriteLine("this is Print in interface Ifirst");
        }
         void Isecond.print()
        {
            Console.WriteLine("Print Isecond");
        }
    }
}
