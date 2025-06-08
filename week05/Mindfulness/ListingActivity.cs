
public class ListingActivity : Activity {
    private int _count;
    private List<string> _prompts;
    private List<string> _userResponses = new List<string>();

    public ListingActivity(string name, string description): base(name, description){
        SetPrompts();
        _count = 0;
    }

    public void Run() {
        Console.WriteLine("Get ready...");
        DisplayStartingMessage();
        DisplayArea();
        DisplayEndingMessage();
    }

      public string GetRandomPrompt(){
            if(_prompts.Count == 1){
                SetPrompts();
                return _prompts[0];
            } 
            Random random = new Random();
            int index = random.Next(0, _prompts.Count - 1);
            string prompt =  _prompts[index];
            _prompts.RemoveAt(index);
            return prompt;
    }

    public void DisplayPrompt(){
         Console.WriteLine(" --- " + GetRandomPrompt() + " --- ");
    }

       public void SetPrompts(){
         _prompts = new List<string>{
           "Who are people that you appreciate?",
           "What are personal strengths of yours?",
           "Who are people that you have helped this week?",
           "Who are some of your personal heroes?",
           "When have you felt the Holy Ghost this month?"
         }; 
    }
    

    public int GetCount(){
        return _count;
    }

       public void DisplayArea(){
      int second = GetDuration();
       int counter = 5;
       Console.WriteLine("\n List as many responses you can to the following prompt: ");
       DisplayPrompt();
       Console.Write("You may begin in: ");
       ShowCountDown(counter);
       Console.WriteLine();
        DateTime startTime = DateTime.Now;
       DateTime futureTime = startTime.AddSeconds(second);
       while(futureTime > DateTime.Now){
          Console.Write(" > ");
          string line = Console.ReadLine();
          SaveResponse(line);
       }
      Console.WriteLine($"\n You listed {_count}  itmes. \n");
    }

    public void SaveResponse(string response){
         if(response.Trim().Length < 1) return;
         _userResponses.Add(response);
         _count = _userResponses.Count;
    }
}
