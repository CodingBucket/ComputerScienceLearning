using System;

public class Emplyee
{
    public string firstName;
    public string lastName;

    public Emplyee() {}

    public void PrintFullName()
    {
        Console.WriteLine(firstName + " " + lastName);
    }
}

public class PartTime : Emplyee
{
    public float hourlyRate;

    // Method Hidding (parent class method is hidding using the child class method)
    public new void PrintFullName()
    {
        Console.WriteLine(firstName + " " + lastName + " from PartTime class");

        // Calling base class method from the child class method.
        base.PrintFullName();
    }
}

public class Program
{
    public static void Main(string[] arg)
    {
        PartTime part = new PartTime
        {
            firstName = "Hasan",
            lastName = "Khan"
        };
        part.PrintFullName();

        // Calling parent call method
        ((Emplyee)part).PrintFullName();

        Emplyee emp = new PartTime
        {
            firstName = "axa",
            lastName = "Khaxaan"
        };
        emp.PrintFullName();

        Console.ReadKey();
    }
}





