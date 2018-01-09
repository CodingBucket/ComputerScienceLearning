using System;

class Program
{
    public static void Main(string[] arg)
    {
        int num = 20;

        switch (num)
        {
            case 10:
                Console.WriteLine("Number is 10");
                break;
            case 20:
                Console.WriteLine("Number is 20");
                break;
            case 30:
                Console.WriteLine("Number is 30");
                break;
            default:
                Console.WriteLine("Number is default");
                break;
        }

        Console.ReadKey();
    }
}



 
