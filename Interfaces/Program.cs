using System;

interface ICustomer
{
    void Print();
}

interface ICustomer2
{
    void Print2();
}
class Customer : ICustomer, ICustomer2
{
    public void Print()
    {
        Console.WriteLine("Interface Example");
    }
    public void Print2()
    {
        Console.WriteLine("Hello Rishabh");
    }
}
public class Program
{
    public static void Main()
    {
        Customer C1 = new Customer();
        C1.Print();
        C1.Print2();
    }
}
