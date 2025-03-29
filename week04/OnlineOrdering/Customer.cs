public class Customer{
    private string _name;
    
    public Customer(string name){
        _name = name;
    }

    public string Address(Address address){
        if (address.UsaOrNot()){
            return "PACKAGE TO USA";
        }
        else{
            return "PACKAGE TO OUTSIDE";
        }
    }

    public string GetName(){
        return _name;
    }
}