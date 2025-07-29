using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class MethodOverloadingDemo
    {
        public void Show()
        {
            Console.WriteLine("Overloaded Add methods:");
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(2.5, 3.1));
            Console.WriteLine(Add(1, 2, 3));
        }

        int Add(int a, int b) => a + b;
        double Add(double a, double b) => a + b;
        int Add(int a, int b, int c) => a + b + c;
    }
}
