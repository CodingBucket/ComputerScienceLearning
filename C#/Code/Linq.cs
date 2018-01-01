using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] arg)
    {
        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 2, 3, 4, 5 };

        // Union example. Take all the element of two array
        var union = array1.Union(array2);
        foreach (int u in union)
            Console.WriteLine(u);
        Console.WriteLine("-----");

        // Intersect example. Take only commen element
        var intersect = array1.Intersect(array2);
        foreach (int value in intersect)
            Console.WriteLine(value);
        Console.WriteLine("-----");

        // Except exmaple. Take only not common element
        var except = array1.Except(array2);
        foreach (int value in except)
            Console.WriteLine(value);

        Console.ReadKey();
    }
}


 
