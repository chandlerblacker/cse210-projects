using System;

public class Product
{
    private string _name;
    private int _productID;
    private double _price;
    private int _quantity;

    public Product(string name, int productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public double getPrice()
    {
        return _price * _quantity;
    }

    public int getID()
    {
        return _productID;
    }

    public string getName()
    {
        return _name;
    }
}