using System;

public class Program
{
    public static void Main(string[] arg)
    {
        Circle c1 = new Circle(12);
        c1.CalculateArea();

        Circle c2 = new Circle(5);
        c2.CalculateArea();

        Console.ReadKey();
    }
}

public class Circle
{
    public static float _PI;
    public int _radius;

    static Circle()
    {
        _PI = 3.1416F;
        Console.WriteLine("Static constructor called");
    }

    public Circle(int radius)
    {
        _radius = radius;
        Console.WriteLine("constructor called");
    }

    public void CalculateArea()
    {
        float area = _PI * _radius * _radius;
        Console.WriteLine(area);
    }
}




 
