public class Product
{
    private string _productName;
    private int _productID, _quantity;
    private float _price;

    public Product(string productName, int productID, int quantity, float price)
    {
        _productName = productName;
        _productID = productID;
        _quantity = quantity;
        _price = price;
    }

    public float GetTotal()
    {
        return _price * _quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public int GetProductID()
    {
        return _productID;
    }


}