using System;

public abstract class AbstractClass
{
    public abstract void Print();
}

class Customer: AbstractClass
{
    public override void Print()
    {
        Console.WriteLine("asxas");
    }
}

public class Program
{
    public static void Main(string[] arg)
    {
        Customer cus = new Customer();
        cus.Print();

        Console.ReadKey();
    }
}


