public class Reception : Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _type;
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private string _email;

    public Reception(string title, string description, string date, string time, string street, string city, string state, string country, string email)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _type = "Reception";
        _email = email;
    }

    public void printStandard()
    {
        _address = new Address(_street, _city, _state, _country);
        standardD(_title, _description, _date, _time, _address.fullAddress());
        Console.WriteLine();
    }

    public void printShort()
    {
        shortD(_type, _title, _date);
    }

    public void printFull()
    {
        _address = new Address(_street, _city, _state, _country);
        standardD(_title, _description, _date, _time, _address.fullAddress());
        Console.WriteLine($"RSVP: {_email}\n");
    }
}