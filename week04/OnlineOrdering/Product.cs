public class Product {
    private int _id;
    private double _price;
    private string _name;
    private int _quantity;

    private double _totalCost;

    public Product(string name, double price, int quantity){
        Random random = new Random();
        _id = random.Next(101, 10001);
        _name = name;
        _price = price;
        _quantity = quantity;
        
    }

    public double GetTotalCost(){
        return _price * _quantity;
    }

    public string GetName(){ return _name; }
    public int GetId(){ return _id; }
    public double GetPrice(){ return _price; }
    public int GetQuantity(){ return _quantity; }
       
}