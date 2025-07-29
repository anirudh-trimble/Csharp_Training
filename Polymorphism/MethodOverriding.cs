using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks");
        }
    }

    internal class MethodOverridingDemo
    {
        public void Show()
        {
            Animal a = new Dog();
            a.Speak(); // Output: Dog barks
        }
    }
}
