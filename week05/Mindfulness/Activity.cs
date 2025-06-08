
public class Activity {
     private string _name;
     private string _description;
     private int _duration;

     public Activity(string name, string description){
              _name = name;
              _description = description;
     }

     public void Run(){}

     public void DisplayStartingMessage(){}

     public void DisplayEndingMessage(){}
     public void ShowSpinner(int second){}
     public void ShowCountDown(int second) {}
}
