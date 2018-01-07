using System;

class Program
{
    public static void Main(string[] arg)
    {
        // Read name from user
        string name = Console.ReadLine();

        // Concatination systax for print
        Console.WriteLine("Your name is " + name);

        // Placeholder systax to print
        Console.WriteLine("Your name is {0}", name);

        Console.ReadKey();
    }
}


 
