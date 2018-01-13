using System;

public class Program
{
    public static void Main(string[] arg)
    {
        PartTime part = new PartTime();
        part.firstName = "Hasan";
        part.lastName = "Khan";
        part.hourlyRate = 12.00F;
        part.PrintFullName();

        PartTime part1 = new PartTime();
        part1.PrintFullName();
        Console.ReadKey();
    }
}

public class Emplyee
{
    public string firstName;
    public string lastName;
    public string email;

    public Emplyee() {}

    public Emplyee(string name)
    {
        firstName = name;
    }

    public void PrintFullName()
    {
        Console.WriteLine(firstName + " " + lastName);
    }
}

public class FullTime : Emplyee
{
    public float yearlyRate;
}

public class PartTime : Emplyee
{
    public PartTime() : base("msg from child class")
    {

    }

    public float hourlyRate;
}





