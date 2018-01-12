using System;

class Program
{
    public static void Main(string[] arg)
    {
        Customer cus = new Customer("Hasan", "Khan");
        cus.PrintFullName();
        Console.ReadKey();
    }
}

public class Customer
{
    public string _firstName;
    public string _lastName;

    public Customer(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public void PrintFullName()
    {
        string fullName = _firstName + " " + _lastName;
        Console.WriteLine("Full name is {0}", fullName);
    }

    // Destructor 
    ~Customer()
    {
        // cleanup code goes here
    }
}




 
