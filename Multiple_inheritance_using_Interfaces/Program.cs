using System;
namespace MultipleInheritance
{
    interface I1
    {
        void First();
    }
    class A : I1
    {
        public void First()
        {
            Console.WriteLine("A");
        }
    }
    interface I2
    {
        void Second();
    }
    class B : I2
    {
        public void Second()
        {
            Console.WriteLine("B");
        }
    }

    class AB : I1, I2
    {
        A a = new A();
        B b = new B();
        public void First()
        {
            a.First();
        }
        public void Second()
        {
            b.Second();
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            AB ab = new AB();
            ab.First();
            ab.Second();
        }
    }
}