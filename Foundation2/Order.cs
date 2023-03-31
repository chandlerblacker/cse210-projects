public class Order
{
    public List<Product> _products = new List<Product>();
    private Customer _customer;
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private string _name;
    private double _totalPrice = 0;
    private double _fee;

    public Order(string street, string city, string state, string country, string name)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _name = name;
        
    }

    public double getTotalPrice()
    {
        foreach(Product product in _products)
        {
            _totalPrice += product.getPrice();
        }
        if(_customer.isUSA())
        {
            _fee = 5;
        }
        else
        {
            _fee = 35;
        }

        _totalPrice += _fee;
        return _totalPrice;
    }

    public void printPacking()
    {
        Console.WriteLine("********************");
        foreach(Product product in _products)
        {
            Console.WriteLine($"{product.getID()}, {product.getName()}");
        }
        Console.WriteLine("********************");
        Console.WriteLine();
    }

    public void printShipping()
    {
        _customer = new Customer(_name, _street, _city, _state, _country);
        Console.WriteLine("********************");
        Console.WriteLine($"{_customer.getName()}, {_customer.getAddress()}");
        Console.WriteLine("********************");
        Console.WriteLine();
    }
}