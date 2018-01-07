/* Write a C# program to reverse the words of a sentence. Go to the editor
Sample Output:
Original String: one two three four.
Reverse String: four three two one */

using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string s = "one two three four";
            string[] stringList = s.Split(' ');
            string reverseString = string.Empty;
            for (int i = stringList.Length - 1; i>=0; i--)
            {
                reverseString = reverseString + stringList[i] + " ";
            }           
            Console.WriteLine(reverseString);
            Console.ReadKey();
        }        
    }
}
