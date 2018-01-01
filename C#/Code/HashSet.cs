using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] arg)
    {
        // HashSet example. HashSet has all unique value
        HashSet<int> firstset = new HashSet<int>();
        for (int i = 1; i <= 10; i++)
            firstset.Add(5 * i);
        foreach (int a in firstset)
            Console.WriteLine(a);

        Console.ReadKey();
    }
}


 
