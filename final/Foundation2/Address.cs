using System;

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address (string street, string city, string state, string country)
    {

    }

    public bool ValidateCountry(string country)
    {
        return true;
    }

    public string DisplayAddress()
    {
        return $"{_street}, {_city} - {_state} : {_country}";
    }
}