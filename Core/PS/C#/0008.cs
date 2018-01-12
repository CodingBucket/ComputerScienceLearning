/*  Write a C# program to check if a string starts with a specified word. Go to the editor
Note: Suppose the sentence starts with "Hello"
Sample Data: string1 = "Hello how are you?"
Result: Hello.
Sample Output:
Input a string : Hello how are you? 
True */

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();
            if (s.Length > 0)
            {
                Console.WriteLine( (s.Length<6 && s.Equals("Hellow")) || s.StartsWith("Hellow "));
            }
            Console.ReadKey();
        }        
    }
}
