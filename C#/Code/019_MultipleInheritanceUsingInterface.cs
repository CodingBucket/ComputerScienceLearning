using System;

interface IA
{
     void PrintA();
}

class A: IA
{
    public void PrintA()
    {
        Console.WriteLine("A");
    }
}

interface IB
{
    void PrintB();
}

class B : IB
{
    public void PrintB()
    {
        Console.WriteLine("B");
    }
}

class AB: IA, IB
{
    public void PrintA()
    {
        A a = new A();
        a.PrintA();
    }

    public void PrintB()
    {
        B b = new B();
        b.PrintB();
    }
}

public class Program
{
    public static void Main(string[] arg)
    {
        AB ab = new AB();
        ab.PrintA();
        ab.PrintB();

        Console.ReadKey();
    }
}

