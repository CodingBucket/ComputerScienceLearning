package javaapplication;

/*     
    Constructor overloading:
	
    	# Constructor is a default public method for class.
    	
	# Contructor method is always called when class is called.
	
	# Constructor method name and class name is always same.
	
	# Multiple constructor function canbe made  depending on different type of parameter.it is called contructor overloding	  
*/

public class JavaApplication {

    public static void main(String[] args) {
        
	/*
	*	Creating new object of A class
	*	A is the type
	*	obj is the object reference
	*	new is which allocate the memory for the object
	*	A() is the contructor function
	*/
        A obj = new A(1);
             
    }  
      
}

class A{
    public A(){
        System.out.println("Constructom without parem");
    }
    public A(int i){
        System.out.println("Constructom without parem "+i);
    }
}

