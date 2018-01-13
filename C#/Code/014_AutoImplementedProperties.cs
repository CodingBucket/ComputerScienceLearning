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







