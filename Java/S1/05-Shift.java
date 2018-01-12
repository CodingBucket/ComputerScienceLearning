package javaapplication1;

public class JavaApplication1 {

    public static void main(String[] args) {
        
       // Left shift and right shift
       int a = 8; // 1 0 0 0
       
       // Left shift add two zero at the end
       int b = a << 2; // 1 0 0 0 0 0 
       
       // Right shift remove last two bit
       int c = a >> 2; // 10
       
       System.out.println("Left shift = "+ b);
       System.out.println("Right shift = "+ c);
        
    }
    
}
