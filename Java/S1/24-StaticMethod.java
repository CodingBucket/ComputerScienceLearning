package javaapplication1;

/*     
   # Static method:
	Static method of a class canbe called without creating object of a class
*/

public class JavaApplication1 {

    public static void main(String[] args) {       
           A.test();
    }  
      
}

class A{ 
      
    public static void test(){
        System.out.println("In A class test method");
    }
}



