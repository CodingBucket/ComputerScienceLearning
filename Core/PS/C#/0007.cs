/* Write a C# program to check if a given positive number is a multiple of 3 or a multiple of 7. Go to the editor
Sample Output:
Input first integer:
15 
True */

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if ( num > 0)
            {
                Console.WriteLine(num % 3 == 0 || num % 7 == 0);
            } 
            Console.ReadKey();
        }        
    }
}
