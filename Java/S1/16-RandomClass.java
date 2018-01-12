package javaapplication1;

import java.util.Random;

/*     
    Random class
*/

public class JavaApplication1 {

    public static void main(String[] args) {
        
        Random r = new Random();
        int a[] = new int[4];
        
        for(int i=0;i<a.length;i++){
            a[i] = r.nextInt(50);
        }
        
        // Enhanched for loop
        for(int i : a){
            System.out.println(i);
        }
        
             
    }  
    
    
}
