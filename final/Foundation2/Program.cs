using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Creatign objects
        Address a1 = new Address("50 E North Temple St", "Salt Lake City", "UT", "USA");
        Customer c1 = new Customer("The Church of Jesus Christ of Latter-Day Saint", a1);
        Product p1 = new Product("Book of Mormon", "AA01", 5, 2);
        Product p2 = new Product("Pen", "AA02", 0.50, 3);

        Address a2 = new Address("123 Paulista Ave", "Sao Paulo", "SP", "BR");
        Customer c2 = new Customer("Vinicius", a2);
        Product p3 = new Product("SmartPhone", "AA20", 200, 1);
        Product p4 = new Product("Laptop", "AB02", 500, 1);

        // Creating Orders
        Order o1 = new Order(c1);
        o1.AddProduct(p1);
        o1.AddProduct(p2);

        Order o2 = new Order(c2);
        o2.AddProduct(p3);
        o2.AddProduct(p4);

        // Displaying Orders
        o1.CalculateOrderTotal(1);
        o1.DisplayPackingLabel();
        o1.DisplayShippingLabel();

        o2.CalculateOrderTotal(2);
        o2.DisplayPackingLabel();
        o2.DisplayShippingLabel();
    }
}