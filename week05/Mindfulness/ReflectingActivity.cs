public class ReflectingActivity : Activity {
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description):base(name, description){
       SetPrompts();
       SetQuestions();
    }

    public void Run(){
        Console.WriteLine("Get ready...");
        ShowSpinner(4); 
        DisplayStartingMessage();
        DisplayArea();
        DisplayEndingMessage();
    }
   
      public void SetPrompts(){
         _prompts = new List<string>{
           "Think of a time when you stood up for someone else.",
           "Think of a time when you did something really difficult.",
           "Think of a time when you helped someone in need.",
           "Think of a time when you did something truly selfless."
         }; 
    }

    public void SetQuestions(){
          _questions = new List<string>{
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
          };
    }

        public string GetRandomPrompt(){
            Random random = new Random();
            string prompt =  _prompts[random.Next(0, _prompts.Count - 1)];
            return prompt;
    }

    public string GetRandomQuestion(){
             Random random = new Random();
            string question =  _questions[random.Next(0, _questions.Count - 1)];
            return question;
    }
    public void DisplayPrompt(){
         Console.WriteLine(" --- "+GetRandomPrompt() + " --- ");
    }
    public void DisplayQuestion(){
         Console.Write(" > " + GetRandomQuestion());
    }

    public void DisplayArea(){
      int second = GetDuration();
       int counter = 6;
       Console.WriteLine("\n Consider the following prompt: ");
       DisplayPrompt();
       Console.WriteLine("When you have something in mind, press enter to continue.");
       string line = Console.ReadLine();
       Console.WriteLine("Now ponder on each of the following quesion as they related to this experience.");
       Console.Write("You may begin in: ");
       ShowCountDown(counter);
        DateTime startTime = DateTime.Now;
       DateTime futureTime = startTime.AddSeconds(second);
       while(futureTime > DateTime.Now){
          Console.Clear();
          DisplayQuestion();
          ShowSpinner(counter);
       }
    }
}
