package javaapplication1;

/*     
# Abstraction :
	A class with atleeast one abstract class is called abstract class.
	
	a. abstract methods are methods that can only be declared, not defined.
	b. abstract class can have abstract method.
	c. you can not create objects of abstract class.
	d. in abstract class you can define method.
*/

public class JavaApplication1 {

    public static void main(String[] args) {       
           Phone1 obj = new Phone3();
           obj.call();
           obj.move();
           obj.dance();
           obj.cook();
    }  
      
}

abstract class Phone1{  // Abstract class
    public void call(){
        System.out.println("can call");
    }
    public abstract void move();
    public abstract void dance();
    public abstract void cook();
}

abstract class Phone2 extends Phone1{  // Abstract class
    public void move(){
        System.out.println("can move");
    }
}

class Phone3 extends Phone2{   // Concrete class
    public void dance(){
        System.out.println("can dance");
    }
    public void cook(){
        System.out.println("can cook");
    }
}


 