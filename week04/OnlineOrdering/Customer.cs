// This class represents a customer, containing their name and address.
// It demonstrates object composition, where a Customer object "has-a" Address object.
public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Getter methods for private fields
    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    // Checks if the customer lives in the USA by calling the address method.
    public bool IsUSA()
    {
        return _address.IsUSA();
    }
}
