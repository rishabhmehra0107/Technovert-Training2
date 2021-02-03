using System;
using System.Collections.Generic;
namespace Generics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool result = Calculator.Equal<int>(1, 2);
            if (result == true)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
    public class Calculator
    {
        public static bool Equal<T>(T val1, T val2)
        {
            return val1.Equals(val2);
        }
    }
}
