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
         Iphone obj = new Iphone();
         Samsang obj1 = new Samsang();
         show(obj);
         show(obj1);
    }  
    
    public static void show(Phone obj){
        obj.showConfig();
    }
      
}

abstract class Phone{  
    public abstract void showConfig();
}

class Iphone extends Phone{
    public void showConfig(){
        System.out.println("its iphone");
    }
}

class Samsang extends Phone{
    public void showConfig(){
        System.out.println("its Samsang");
    }
}



 