using System;

interface I1
{
    void InterfaceMethod();
}

interface I2
{
    void InterfaceMethod();
}

class Customer : I1, I2
{
    void I1.InterfaceMethod()
    {
        Console.WriteLine("I1 interface method");
    }

    void I2.InterfaceMethod()
    {
        Console.WriteLine("I2 interface method");
    }
}

public class Program
{
    public static void Main(string[] arg)
    {
        I1 cust = new Customer();
        cust.InterfaceMethod();

        Customer c1 = new Customer();
        ((I1)c1).InterfaceMethod();
        ((I2)c1).InterfaceMethod();

        Console.ReadKey();
    }
}







