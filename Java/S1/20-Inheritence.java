package javaapplication1;

/*     
   Inheritance
*/

public class JavaApplication1 {

    public static void main(String[] args) {
        
       B obj = new B();
             
    }  
      
}

class A{  // Super or parent class
    public A(){
        System.out.println("In A class");
    }
}

class B extends A{ // Sub or child class
    public B(){
        System.out.println("In B class");
    }
}

