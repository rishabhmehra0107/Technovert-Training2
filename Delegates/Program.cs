using System;
public delegate void TechnovertTraining(string Message);

class Program
{
    public static void Main(string[] args)
    {
        TechnovertTraining tt = new TechnovertTraining(Training);
        tt("Welcome to Technovert");
    }

    public static void Training(string str)
    {
        Console.WriteLine(str);
    }
}