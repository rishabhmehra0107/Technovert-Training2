using System;

public abstract class Customer
{
    public abstract void Print();
    public void Print2()
    {
        Console.WriteLine("Technovert");
    }
}



public class Program : Customer
{
    public override void Print()
    {
        Console.WriteLine("Abstract class Example");
    }

    public static void Main()
    {
        Customer C = new Program();
        C.Print();
        C.Print2();
    }
}
