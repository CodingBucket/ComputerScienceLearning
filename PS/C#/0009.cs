/* Write a C# program to count a specified number in a given array of integers. Go to the editor
Test Data: */

using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // aceg
            int[] num = { 1, 5, 3, 5};
            string r = string.Empty;
            
            Console.WriteLine(num.Count(s => s == 5));
            Console.ReadKey();
        }        
    }
}
