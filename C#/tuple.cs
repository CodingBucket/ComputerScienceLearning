using System;

class Program
{
    public static void Main(string[] arg)
    {
        var tpl = new Tuple<int, string, bool>(1, "Hasan", true);
        Console.WriteLine(tpl.Item1);
        Console.WriteLine(tpl.Item2);
        Console.WriteLine(tpl.Item3);

        var tpl1 = Tuple.Create("string", true, new string[] { "a", "b", "c" });
        foreach(var t in tpl1.Item1)
            Console.WriteLine(t);

        Console.ReadKey();
    }
}


 