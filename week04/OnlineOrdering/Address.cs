public class Address{
    private string _street;
    private string _city;
    private string _state; //or province
    private string _country;

    public Address(string street, string city, string state, string country){
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    
    public bool UsaOrNot(){
        if (_country == "EUA" || _country == "United States"){
            return true;
        }
        else{
            return false;
        }
    }

    public string DisplayAddress(){
        return $"\nStreet: {_street}\nCity/State:{_city}/{_state}\nCountry: {_country}\n";
    }
}