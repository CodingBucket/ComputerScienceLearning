/* Write a C# program to convert a decimal number to hexadecimal number. Go to the editor
Sample Output:
Hexadecimal number: 4B0
Convert to- 
Decimal number: 1200  */

using System;
using System.Collections.Generic;
public class Exercise30 {
 public static void Main() {
      
     string hexval = "4B0";
     Console.WriteLine("Hexadecimal number: "+hexval);
     int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
     Console.WriteLine("Convert to-");
     Console.WriteLine("Decimal number: "+decValue);
   }
}
