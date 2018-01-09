using System;

class Program
{
    public static void Main(string[] arg)
    {
        // Call static method
        Demo.StaticMethod();

        // Call insance method
        Demo pro = new Demo();
        pro.InstanceMethod();

        Console.ReadKey();
    }
}

class Demo
{
    public void InstanceMethod()
    {
        Console.WriteLine("This is a instance method");
    }

    public static void StaticMethod()
    {
        Console.WriteLine("This is a static method");
    }
}



 
