using System;

namespace Generics_Function_Overloading
{
    public class Example
    {
        public void Animal1<T>(T val)
        {
            Console.WriteLine(val.GetType().Name);
        }
        public void Animal1<T>(int x)
        {
            Console.WriteLine(x.GetType().Name);
        }
        public void Animal2<T>(T x)
        {
            Animal1(x);
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Example ex = new Example();
            ex.Animal1("Testing data");
            ex.Animal1(90);
            ex.Animal2(5050);
        }
    }
}
