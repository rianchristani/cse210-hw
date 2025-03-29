using System.ComponentModel;

public class Order{
    private List<Product>_products = new List<Product>();
    private List<Customer>_customer = new List<Customer>();

    public void AddCostumer(Customer costumer){
        _customer.Add(costumer);
    }
    
        public void AddProducts(Product product){
        _products.Add(product);
    }
    int totalPrice = 0;
    public void TotalOrder(Address address){
        if (address.UsaOrNot() == true){
            totalPrice = 5;
            foreach (Product product in _products){
                totalPrice += product.TotalItemsPrice();
                }
            }

        else{
             totalPrice = 35;   
                foreach (Product product in _products){
                totalPrice += product.TotalItemsPrice();
                }
            }
    }

    public void PackingLabel(){
        foreach (Product product in _products){
             Console.WriteLine($"Nome: {product.GetName()}, Preço: {product.GetPrice()}, Quantidade: {product.GetQuantity()}");
    }
    string valueUS = string.Format(System.Globalization.CultureInfo.GetCultureInfo("en-US"), "{0:C}", totalPrice); 
    Console.WriteLine($"\nTotal order: {valueUS}\n");
    }

    public void ShippingLabel(Customer customer, Address address){
        Console.WriteLine($"{customer.getName()} -- {customer.Address(address)}");
        Console.WriteLine(address.DisplayAdress());
    }    

}