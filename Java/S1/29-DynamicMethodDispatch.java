package javaapplication1;

/*     
	Dynamic method dispatch
*/


public class JavaApplication1 {

    public static void main(String[] args) {     
        
        Animal obj = new Dog();
        show(obj);
        
        Animal obj1 = new Cat();
        show(obj1);
         
    }  
    
    public static void show(Animal obj){
        obj.move();
    }
    
}

class Animal{
    public void move(){
        System.out.println("In Animal class");
    }
}

class Dog extends Animal {
    public void move(){
        System.out.println("In Dog class");
    }
}

class Cat extends Animal {
    public void move(){
        System.out.println("In Cat class");
    }
}


 