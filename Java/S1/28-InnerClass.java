package javaapplication1;

/*     
	Inner Class :
*/


public class JavaApplication1 {

    public static void main(String[] args) {       
         A a = new A();
         A.B obj = a.new B();
         obj.show();
    }  
    
}

class A{
    class B{
        public void show(){
            System.out.println("In class B");
        }
    }
}



 