public class Order {
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products){
        _customer = customer;
        _products = products;
    }

    public double GetTotalCost(){
        double total = 0;
        foreach(Product product in _products)
            total += product.GetTotalCost();
        double shippingCost;
        if(_customer.GetCountry() == "USA")
            shippingCost = 5;
        else shippingCost = 35;
        return total + shippingCost;
    }

    public string GetShippingLabel(){
        string shippingLable = $"Name: {_customer.GetName()}\n Full Address: {_customer.GetFullAddress()}";
        return shippingLable;
    }
   
   public string GetPackageLabel(){
    string packageLabel = "";
    foreach(Product product in _products){
        packageLabel += $"{product.GetName()}: {product.GetId()} \n";
    }
    return packageLabel;
   }
      

}