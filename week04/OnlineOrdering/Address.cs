public class Address
{
    private string _street, _city, _province, _country;
    private bool _isInUS;

    public Address(string street, string city, string province, string country, bool isInUS = true)
    {
        _street = street;
        _city = city;
        _province = province;
        _country = country;
        _isInUS = isInUS;
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_province} {_country}";
    }

    public bool GetIsInUSA()
    {
        return _isInUS;
    }
}