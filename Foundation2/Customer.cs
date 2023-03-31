using System;

public class Customer
{
    private string _name;
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private Address _address;

    public Customer(string name, string street, string city, string state, string country)
    {
        _name = name;
        _street = street;
        _city = city;
        _state = state;
        _country = country;

    }
    
    public bool isUSA()
    {
        return _address.isUSA();
    }

    public string getName()
    {
        return _name;
    }

    public string getAddress()
    {
        _address = new Address(_street, _city, _state, _country);
        return _address.fullAddress();
    }
}