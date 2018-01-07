using System;

class Program
{
    public static void Main(string[] arg)
    {
        // Escape sequence
        string name = "\"hasan";
        Console.WriteLine(name);

        // Verbatim literal (it prints the escape sequence)
        string drive = @"c:\\program\\folder";
        Console.WriteLine(drive);

        Console.ReadKey();
    }
}


 
