public class Address {
    private string _street;
    private string _city;
    private string _state_province;
    private string _country;

    public Address(string street, string city, string state_province, string country){
        _street = street; _city = city; _state_province = state_province;
        _country = country;
    }

    public void SetStreet(string street){ _street = street; }
    public string GetStreet(){ return _street; }

    public void SetCity(string city){ _city = city; }
    public string GetCity(){ return _city; }

    public void SetStateProvince(string state_province) { _state_province = state_province;}
    public string GetSateProvince(){ return _state_province; }

    public void SetCountry(string country){ _country = country; }
    public string GetCountry(){ return _country; }

    public string GetFullAddress(){
        return $"{_street}, {_city}, {_state_province}, {_country}";
    }
}