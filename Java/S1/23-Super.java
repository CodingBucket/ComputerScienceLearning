package javaapplication1;

/*     
   Method overloading:
    multiple method in the same class but with different parameter.
*/

public class JavaApplication1 {

    public static void main(String[] args) {       
       B obj = new B();
       obj.test();      
    }  
      
}

class A{  // Super or parent class
    public A(){
        System.out.println("In A class");
    }    
    public void test(){
        System.out.println("In A class test method");
    }
}

class B extends A{ // Sub or child class
    public B(){
        // super() method is exist here which call the super class constructor method
        System.out.println("In B class");
    }
    
    public void test(){
        // Calling the super class test method
        super.test();
        System.out.println("In B class test method");
    }
    
}

