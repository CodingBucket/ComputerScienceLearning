package javaapplication1;

/*     
   Method overriding
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
        System.out.println("In B class");
    }
    /*
    * Here this test method is overriding the parent class test method
    * if this method were not available in this class then the parent class
    * test would be called
    */
    public void test(){
        System.out.println("In B class test method");
    }
}

