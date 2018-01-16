using System;

interface ICustomer
{
    void Print();
}

interface I2
{
    void Print2();
}

class Customer : ICustomer, I2
{
    public void Print()
    {
        Console.WriteLine("print");
    }

    public void Print2()
    {
        Console.WriteLine("print2");
    }
}

public class Program
{
    public static void Main(string[] arg)
    {
        ICustomer cust = new Customer();
        cust.Print();

        Console.ReadKey();
    }
}







