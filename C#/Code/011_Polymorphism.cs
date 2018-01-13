using System;

public class Emplyee
{
    public string firstName = "FN";
    public string lastName = "LN";

    public virtual void FullName()
    {
        Console.WriteLine(firstName + " " + lastName);
    }
}

public class PartTime : Emplyee
{
    public override void FullName()
    {
        Console.WriteLine(firstName + " " + lastName + " from PartTime class");
    }
}

public class FullTime : Emplyee
{
    public override void FullName()
    {
        Console.WriteLine(firstName + " " + lastName + " from FullTime class");
    }
}

public class Program
{
    public static void Main(string[] arg)
    {
        Emplyee[] emp = new Emplyee[3];
        emp[0] = new Emplyee();
        emp[1] = new PartTime();
        emp[2] = new FullTime();

        foreach(var em in emp)
            em.FullName();           

        Console.ReadKey();
    }
}

