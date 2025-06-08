


public class Activity {
     private string _name;
     private string _description;
     private int _duration;

     public Activity(string name, string description){
              _name = name;
              _description = description;
     }

     public void DisplayStartingMessage(){
        Console.WriteLine($"Welcome to {_name} Activity \n");
        Console.WriteLine(_description + "\n");
        Console.Write("How long,  in second,  do you like your session to last? ");
        _duration = int.Parse(Console.ReadLine());
     }

     public void DisplayEndingMessage(){
        Console.WriteLine("Weldone !!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
     }

     public void ShowSpinner(int second = 4){
        // 1000 == 1 second
        int time = 320;
       DateTime startTime = DateTime.Now;
       DateTime futureTime = startTime.AddSeconds(second);
       while(futureTime > DateTime.Now){
            Console.Write("_");
            OverWrite(time);
            Console.Write("\\");
            OverWrite(time);
            Console.Write("|");
            OverWrite(time);
            Console.Write("/");
            OverWrite(time);
        }
     }

     private void OverWrite(int time = 200){
          Thread.Sleep(time);
          Console.Write("\b \b");
     }

     public void ShowCountDown(int second) {
          Console.Write(second);
        for(int i = second-1; i > 0; i--){
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write(i);
        }
        Console.Write("\b \b");
     }

     public int GetDuration(){ return _duration ; }
}


