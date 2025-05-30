public class ClassDiagram {

}

public class YouTubeVideos {


    public class Video {
    private string _title;
    private string _author;
    private int _length;

    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length){
           _title = title;
           _author = author;
           _length = length;
    }

    public Video(string title, string author, int length, Comment comment){
           _title = title;
           _author = author;
           _length = length;
           _comments.Append(comment);
    }
    

    public int GetNumberOfComment(){
        return _comments.Count;
    }

    public string GetTitle(){
        return _title;
    }

    public string GetAuthor(){
        return _author;
    }

    public int GetLength(){
        return _length;
    }


    public List<Comment> GetCommentList(){
        return _comments;
    }

    public void AddComment(Comment comment){
        _comments.Add(comment);
    }


}

  // The video Comment class

    public class Comment {
    private string _author;
    private string _comment;

    public Comment(string authorName, string comment){
        _author = authorName;
        _comment = comment;
    }

    public string GetAuthor(){
         return _author;
    }

    public string GetComment(){
        return _comment;
    }

}


}  // End of YouTube Video Design


public class OnlineOrdering{

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


  
public class Customer{
    private string _name;
    private Address _address;

    public Customer(string name, Address address){
        _name = name;
        _address = address;
    }

    public string GetLocation(){
        if(_address.GetCountry() == "USA")
          return "Live in USA";
        return "Live outside USA";
    }

}


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

public class Order {
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, Product products){
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

}







