using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRecord
{
    
    public record carrecord
    {
        public string make { get; init; } = "toyota";
        public string name { get; init; } = "camry";
        public int year { get; init; } = 2022;
        public void display()
        {
            Console.WriteLine($"Make : {make},name: {name}, year: {year}");
        }
    }
}
