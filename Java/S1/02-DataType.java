public class DataType{

	public int a;
	public int b;
	public int sum;

	public static void main(String[] args){

		// Creating a object of DataType Class
		DataType cal = new DataType();

		cal.a = 10;
		cal.b = 20;
		cal.sum = cal.a + cal.b;

		// Print data without new line
		System.out.print(cal.sum);

	}

}