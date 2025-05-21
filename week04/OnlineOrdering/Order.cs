public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> product, Customer customer)
    {
        _products = product;
        _customer = customer;
    }

    public string GetTotalCost()
    {
        float runningTotal = 0;
        foreach (var item in _products)
            runningTotal = runningTotal + item.GetTotal();
        if (!_customer.GetIsInUSA())
            return (runningTotal + 35).ToString("C");
        else
        {
            return (runningTotal + 5).ToString("C");
        }
        // found formatting help at: https://stackoverflow.com/questions/820913/format-number-as-money
    }

    public string GetPackingLabel()
    {
        string compiledProducts = "\nPacking Label:\n";
        foreach (var item in _products)
        {
            compiledProducts += $"Product Name: {item.GetProductName()}\nProduct ID: {item.GetProductID()}\n";
        }
        return compiledProducts;
    }

    public string GetShippingLabel()
    {
        return $"\nShipping Label:\n{_customer.GetCustomerName()}\n{_customer.GetAddress()}";
    }

}