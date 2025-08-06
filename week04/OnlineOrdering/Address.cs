// This class represents a physical address.
// It contains private fields for all address components and methods to access them.
public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    // Getter methods for private fields
    public string GetStreet()
    {
        return _street;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetStateProvince()
    {
        return _stateProvince;
    }

    public string GetCountry()
    {
        return _country;
    }

    // Checks if the country is "USA".
    public bool IsUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    // Returns a formatted string of the full address.
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateProvince}, {_country}";
    }
}
