using System;

class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;

    public Product (string name, string id, string price, string quantity)
    {
        
    }

    public string GetName()
    {
        return _name;
    }

    public string GetId()
    {
        return _id;
    }

    public double CalculateTotalCost()
    {
        return _price * _quantity;
    }
}