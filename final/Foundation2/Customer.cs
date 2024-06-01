using System;

class Customer
{
    private string _name;
    private Address _address;

    public Customer (string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public double CheckCountry()
    {   
        int shippingCost = 5;
        bool validation = _address.ValidateCountry(_address);
        if (validation == false)
        {
            shippingCost = 35;
        }
        return shippingCost;
    }
}