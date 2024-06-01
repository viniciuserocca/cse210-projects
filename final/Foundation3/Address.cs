using System;

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address ()
    {

    }

    public string DisplayAddress()
    {
        return $"{_street}, {_city} - {_state} : {_country}";
    }
}