/* Write a C# program to compute the sum of the first 500 prime numbers. Go to the editor
Sample Output:
Sum of the first 500 prime numbers:
3682913  */

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int i = 2;
            int sum = 0;
            int primeCount = 0;
            while (true)
            {
                bool isPrime = IsPrime(i);
                if (isPrime)
                {
                    sum = sum + i;
                    primeCount++;
                }
                i++;
                if (primeCount == 500) break;
            }           
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        public static bool IsPrime(int i)
        {
            for (int j=2; j<i; j++)
            {
                if (i%j == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
