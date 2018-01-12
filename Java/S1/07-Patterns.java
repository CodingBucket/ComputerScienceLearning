package javaapplication1;

public class JavaApplication1 {

    public static void main(String[] args) {
        
        /*     
            1 2 3 4
            2 3 4 1
            3 4 1 2
            4 1 2 3      
        */
      
        int i,j,k,l=1;
        
        for (i=1;i<=4;i++){   
            k=i;l=1;
            for(j=i;j<=i+3;j++){ 
          
                if(k>4){
                    System.out.print(l);  
                    l++;
                } else {
                    System.out.print(k);
                    k++;
                }
            }
            System.out.println();
        }
  
    }  
    
}
