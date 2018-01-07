using System;

class Program
{
    public static void Main(string[] arg)
    {
        Console.WriteLine("byte max : {0}", byte.MaxValue);
        Console.WriteLine("byte min : {0}", byte.MinValue);

        Console.WriteLine("sbyte max : {0}", sbyte.MaxValue);
        Console.WriteLine("sbyte min : {0}", sbyte.MinValue);

        Console.WriteLine("int max : {0}", int.MaxValue);
        Console.WriteLine("int min : {0}", int.MinValue);

        Console.WriteLine("uint max : {0}", uint.MaxValue);
        Console.WriteLine("uint min : {0}", uint.MinValue);

        Console.WriteLine("long max : {0}", long.MaxValue);
        Console.WriteLine("long min : {0}", long.MinValue);

        Console.WriteLine("ulong max : {0}", ulong.MaxValue);
        Console.WriteLine("ulong min : {0}", ulong.MinValue);

        Console.ReadKey();
    }
}


 
