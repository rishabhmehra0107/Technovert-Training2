using System;
using System.Collections.Generic;

delegate T DelegateExmp<T>(T n);
namespace Generic_Delegates
{
    class MainClass
    {
        static int num = 10;
        public static int add_num(int val)
        {
            num += val;
            return num;
        }
        public static int mul_num(int val)
        {
            num *= val;
            return num;
        }
        public static int div_num(int val)
        {
            num /= val;
            return num;
        }
        public static int getnum()
        {
            return num;
        }
        public static void Main(string[] args)
        {
            DelegateExmp<int> var1 = new DelegateExmp<int>(add_num);
            DelegateExmp<int> var2 = new DelegateExmp<int>(mul_num);
            DelegateExmp<int> var3 = new DelegateExmp<int>(div_num);
            var1(10);
            Console.WriteLine("Value of Num on addition: {0}", getnum());
            var2(10);
            Console.WriteLine("Value of Num on multiplication: {0}", getnum());
            var3(10);
            Console.WriteLine("Value of Num on division: {0}", getnum());
        }
    }
}
