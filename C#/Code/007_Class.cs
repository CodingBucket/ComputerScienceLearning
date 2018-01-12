using System;

class Program
{
    public static void Main(string[] arg)
    {
        Customer c1 = new Customer("Hasan", "Khan");
        c1.PrintFullName();

        Customer c2 = new Customer();
        c2.PrintFullName();

        Console.ReadKey();
    }
}

public class Customer
{
    public string _firstName;
    public string _lastName;

    public Customer() : this("Empty First Name", "Empty Last Name") { }

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




 
