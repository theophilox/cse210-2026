public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalCost()
    {
        double total = 0;

        foreach (Product p in _products)
        {
            total += p.TotalCost();
        }

        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    // Packing label
    public string PackingLabel()
    {
        string result = "Packing Label:";

        foreach (Product p in _products)
        {
            result += "\n" + p.DisplayProduct();
        }

        return result;
    }

    // Shipping label
    public string ShippingLabel()
    {
        return $"\nShipping Label:\n{_customer.Name()}\n{_customer.Address()}";
    }
}