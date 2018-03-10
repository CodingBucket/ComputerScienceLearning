using System;

public class Program
{
    public static void Main(string[] arg)
    {
        CarType car = CarType.Toyota;
        Console.WriteLine(car);

        // Get all enum values
        int[] values = (int[])Enum.GetValues(typeof(CarType));
        foreach (var val in values)
            Console.WriteLine(val);

        // Get all enum names
        string[] names = Enum.GetNames(typeof(CarType));
        foreach (var name in names)
            Console.WriteLine(name);  

        Console.ReadKey();
    }
}

public enum CarType
{
    Toyota = 1,
    Honda = 2,
    Ford = 3
}







