using System;

// Creating Delegte
public delegate void PrintNameDelegate(string msg);

public class Program
{
    public static void Main(string[] arg)
    {
        PrintNameDelegate del = new PrintNameDelegate(PrintName);
        del("Hasan Khan");

        Console.ReadKey();
    }

    public static void PrintName(string name)
    {
        Console.WriteLine(name);
    }
}

