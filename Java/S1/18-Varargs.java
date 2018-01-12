package javaapplication1;

/*     
   Varargs = Variable arguments
*/

public class JavaApplication1 {

    public static void main(String[] args) {
        
       Display obj = new Display();
       obj.show(1,2,3);
             
    }  
      
}

class Display{
    public void show(int ... a){  // Varargs - variable argument
        for(int i : a){
            System.out.println(i);
        }
    }
}
