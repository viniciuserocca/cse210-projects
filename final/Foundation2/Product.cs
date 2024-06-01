using System;

class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;

    public Product (string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetProduct()
    {
        return $"{_id} - {_name}";
    }

    public double CalculateTotalCost()
    {
        return _price * _quantity;
    }
}