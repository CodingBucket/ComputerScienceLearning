using System;

public class Student
{
    private int id;
    public string Name { get; set; }

    public int Id
    {
        set
        {
            if (value > 0)
                id = value;
            else
                Console.WriteLine("Only positive number is allowed.");
        }
        get
        {
            return id;
        }
    }

}

public class Program
{
    public static void Main(string[] arg)
    {
        Student std = new Student
        {
            Id = 12,
            Name = "Hasan"
        };
        Console.WriteLine(std.Id);
        Console.WriteLine(std.Name);

        Console.ReadKey();
    }
}

/*
    # Auto Implemented Properties:
    If there is no editional logic in the property accessors, then we can make use of
    auto-implemneted properties introduced in C# 3.0
    Auto-impplemented properties reduce the amount of code that we have to write.
    When you use auto-implemented properties, the complier creates a private, anonymous field
    that can only accessed through the property's get and set accessors.
*/





