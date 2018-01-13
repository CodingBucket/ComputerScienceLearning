using System;

public class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("From Base Class");
    }
}

public class DerivedClass : BaseClass
{
    public override void Print()
    {
        Console.WriteLine("From Derived Class");
    }
}

public class Program
{
    public static void Main(string[] arg)
    {
        BaseClass emp = new DerivedClass();
        emp.Print();   // Output: "From Derived Class"

        Console.ReadKey();
    }
}

/*
    # Method Overriding:
    In method overriding a base class reference variable pointing to a child class object,
    will invoke the overridden method in the child class.
    It is also called Polymorphism.
*/





