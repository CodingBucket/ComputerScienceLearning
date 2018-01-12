package javaapplication1;

/*     
    Enhanched for loop
*/

public class JavaApplication1 {

    public static void main(String[] args) {
        
        int a[] = new int[4];
        //  1 2 3 4
        
        for(int i=0;i<a.length;i++){
            a[i] = i + 1;
        }
        
        // Enhanched for loop
        for(int i : a){
            System.out.println(i);
        }
        
             
    }  
    
    
}
