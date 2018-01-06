public class MySingleton {
	// placeholder for current singleton object
	private static MySingleton __me = null;

	// private constructor - now no other object can instantiat
	private MySingleton(){ }

	// this is how you ask for the singleton
	public static MySingleton getInstance(){
		// do i exist?
		if(__me == null){
			// if not, instantiate and store
			__me = new MySingleton();
		}
		return __me;
	}

	// additional functionality
	public someMethod(){ //... }
}
