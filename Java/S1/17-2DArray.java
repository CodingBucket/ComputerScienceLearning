package javaapplication1;

/*     
    2D array print
*/

public class JavaApplication1 {

    public static void main(String[] args) {
        
        int a[][] = {            
            {1, 2, 3, 5},
            {6, 7, 8, 9},
            {9, 8, 7, 6}         
        };
        
        for(int i=0;i<3;i++){
            for(int j=0;j<4;j++){
                System.out.print(a[i][j] + " ");
            }
             System.out.println("");
        }
             
    }  
    
    
}
