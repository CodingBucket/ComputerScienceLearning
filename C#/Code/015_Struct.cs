using System;

public struct Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public class Program
{
    public static void Main(string[] arg)
    {
        Student std = new Student
        {
            FirstName = "Hasan",
            LastName = "Khan"
        };
        Console.WriteLine(std.FirstName);

        Console.ReadKey();
    }
}







