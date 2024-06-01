using System;

class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order (Customer customer)
    {   
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void CalculateOrderTotal(int orderNumber)
    {   
        double cost = 0;
        double sumCost = 0;
        double shippingCost = _customer.CheckCountry();
        foreach (Product product in _products)
        {   
            cost = product.CalculateTotalCost();
            sumCost += cost;
        }
        double totalCost = sumCost + shippingCost;

        Console.WriteLine($"Order{orderNumber} Total Cost: ${totalCost}");
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine("Packing Label");
        Console.WriteLine("==========================");
        foreach (Product product in _products)
        {
            Console.WriteLine(product.GetProduct());
        }
        Console.WriteLine();
    }

    public void DisplayShippingLabel()
    {   
        Address a =_customer.GetAddress();

        Console.WriteLine("Shipping Label");
        Console.WriteLine("==========================");
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(a.DisplayAddress());
        Console.WriteLine("\n");
    }
}