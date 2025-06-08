
public class BreathingActivity : Activity {
   

    public BreathingActivity(string name, string description) : base(name, description) {}

    public void CountDownArea(){
       int second = GetDuration();
       int counter = 5;
       DateTime startTime = DateTime.Now;
       DateTime futureTime = startTime.AddSeconds(second);
       Console.WriteLine("\n");
       while(futureTime > DateTime.Now){
          Console.Write("Breath in...");
          ShowCountDown(counter);
          Console.WriteLine("");
          Console.Write("Now Breath out...");
          ShowCountDown(counter);
          Console.WriteLine("\n");
       }
    }

        public void Run(){
        Console.WriteLine("Get ready...");
        ShowSpinner(4);
        DisplayStartingMessage();
        CountDownArea();
        DisplayEndingMessage();
    }


}
