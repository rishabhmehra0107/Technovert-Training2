using System;

interface ICustomer
{
    void Print();
}

interface ICustomer2
{
    void Print();
}

public class Program : ICustomer, ICustomer2
{
    void ICustomer.Print()
    {
        Console.WriteLine("Interface Example");
    }
    void ICustomer2.Print()
    {
        Console.WriteLine("Hello Rishabh");
    }
    public static void Main()
    {
        Program P = new Program();
        ((ICustomer)P).Print();
        ((ICustomer2)P).Print();
    }
}