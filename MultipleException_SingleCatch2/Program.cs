using System;
using System.IO;
namespace ExceptionHandling
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int a = 0, b = 10;
                int c = b / a;
                Console.WriteLine(c);


            }
            catch (Exception ex)
            {
                if (ex is FileNotFoundException)
                    Console.WriteLine("FileNotFound");
                else if (ex is ArithmeticException)
                    Console.WriteLine("Arithmetic Exception");
                else
                    Console.WriteLine("Please check, there is an error");
            }
        }
    }
}