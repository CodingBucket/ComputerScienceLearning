/* Write a C# program to multiply corresponding elements of two arrays of integers. Go to the editor
Sample Output:
Array1: [1, 3, -5, 4]
Array2: [1, 4, -5, -2]
Multiply corresponding elements of two arrays:
1 12 25 -8 */

using System;
using System.Collections.Generic;

public class Exercise31 {
 public static void Main() {
     int[] first_array = {1, 3, -5, 4};
     int[] second_array = {1, 4, -5, -2};
     
      Console.WriteLine("\nArray1: [{0}]", string.Join(", ", first_array));
      Console.WriteLine("Array2: [{0}]", string.Join(", ", second_array));
      
      Console.WriteLine("\nMultiply corresponding elements of two arrays: ");
    
     for (int i = 0; i < first_array.Length; i++)
          {
                
          Console.Write(first_array[i] * second_array[i]+" ");
        }
     Console.WriteLine("\n");
   }
}
