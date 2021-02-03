using System;

interface ICustomer
{
    void Print();
}

class Customer : ICustomer
{
    public void Print()
    {
        Console.WriteLine("Interface Example");
    }
}
public class Program
{
    public static void Main()
    {
        Customer C1 = new Customer();
        C1.Print();
    }
}
