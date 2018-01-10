using System;

class Program
{
    public static void Main(string[] arg)
    {
        Demo pro = new Demo("Hasan", "Khan");

        Console.ReadKey();
    }
}

public class Demo
{
    public string _firstName;
    public string _lastName;

    public Demo(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }
}




 
