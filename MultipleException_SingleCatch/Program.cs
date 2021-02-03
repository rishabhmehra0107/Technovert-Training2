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
                StreamReader sr = new StreamReader("/Users/apple/Desktop/Data1.txt");
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();

            }
            catch (Exception ex)
            {
                if (ex is FileNotFoundException)
                    Console.WriteLine("FileNotFound Exception");
                else if (ex is ArithmeticException)
                    Console.WriteLine("Arithmetic Exception");
                else
                    Console.WriteLine("Please check, there is an error");
            }
        }
    }
}
