package javaapplication1;

/*     
    Armstrong number
    153 -> 1 5 3
        -> 1*1*1 + 5*5*5 + 3*3*3
        -> 1 + 125 + 27
        -> 153 is armstrong number

    370 -> 3 7 0
        -> 3*3*3 + 7*7*7 + 0*0*0
        -> 27 + 343 + 0
        -> 370 is also a armstrong number
*/

public class JavaApplication1 {

    public static void main(String[] args) {

        int n = 153;
        int temp = n;
        int r,sum=0;
        
        while(n>0){
            r = n%10;
            n = n/10;
            sum = sum + r*r*r;
        }
        
        if(temp == sum)
            System.out.print("Ita an armstrong number");
        else
            System.out.print("Ita not an armstrong number");
  
    }  
    
    
}
