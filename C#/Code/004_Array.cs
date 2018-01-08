using System;

class Program
{
    public static void Main(string[] arg)
    {
        // int array
        int[] num = { 1, 2, 3 };
        foreach(int n in num)
            Console.WriteLine(n);

        int[] num1 = new int[3];
        num1[0] = 11;
        num1[1] = 12;
        num1[2] = 13;
        foreach (int n in num1)
            Console.WriteLine(n);

        Console.ReadKey();
    }
}


 
