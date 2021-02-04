using System;
namespace BoxingUnboxing
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int i = 200;
            object o = i;
            try
            {
                int j = (short)o;
                System.Console.WriteLine("Unboxing works fine");
            }
            catch(System.InvalidCastException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
