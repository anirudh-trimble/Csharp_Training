using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Complex
    {
        public int Real { get; }
        public int Imag { get; }

        public Complex(int r, int i)
        {
            Real = r;
            Imag = i;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.Real + b.Real, a.Imag + b.Imag);
        }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
    }

    internal class OperatorOverloadingDemo
    {
        public void Show()
        {
            Complex c1 = new Complex(2, 3);
            Complex c2 = new Complex(4, 5);
            Complex result = c1 + c2;
            Console.WriteLine("Sum of complex numbers: " + result);
        }
    }

}
