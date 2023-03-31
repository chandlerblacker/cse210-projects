using System;

public class Address
{
    public string _street;
    public string _city;
    public string _state;
    public string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool isUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string fullAddress()
    {
        return $"{_street}\n{_city}, {_state}, {_country}";
    }

}