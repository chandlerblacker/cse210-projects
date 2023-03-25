public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Order(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
}