package javaapplication1;

/*     
# Interface :

	a. in interface you can declare a method like abstract class.
	b. in interface you can not define a method.
	c. all the methods in interface is abstruct method.

	a. Marker Interface : without any method.
	b. SAM : single abstract method. In java 1.8 it is also called Functional Interface.

*/

interface Abc{
    void show();
}

class AbcImpl implements Abc{
    public void show(){
        System.out.println("In show");
    }
}

public class JavaApplication1 {

    public static void main(String[] args) {       
         Abc obj = new AbcImpl();
         obj.show();
    }  
    
}




 