using System;

public class BaseClass
{
    public void Print()
    {
        Console.WriteLine("From Base Class");
    }
}

public class DerivedClass : BaseClass
{
    public new void Print()
    {
        Console.WriteLine("From Derived Class");
    }
}

public class Program
{
    public static void Main(string[] arg)
    {
        BaseClass emp = new DerivedClass();
        emp.Print();   // output: "From Base Class"

        Console.ReadKey();
    }
}

/*
 Method Hidding:
 In method overriding a base class reference variable pointing to a child class object,
 will invoke the hidden method in the base class.
*/





