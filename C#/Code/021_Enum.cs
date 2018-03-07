using System;

public class Program
{
    public static void Main(string[] arg)
    {
        CarType car = CarType.Toyota;

        Console.WriteLine(car);

        Console.ReadKey();
    }
}

public enum CarType
{
    Toyota = 1,
    Honda = 2,
    Ford = 3
}







