public class PromptGenerator {
    public List<string> _prompts = new List<string>{
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? ",
        "If I had one thing I could do over today, what would it be? ",
        "What did you do today? ",
        "What is the most striking that happened to you today? ",
        "Tell me about your activities today: ",
    };

     Random random = new Random();
    public string GetRandomPrompt(){
       string prompt =  _prompts[random.Next(0, _prompts.Count - 1)];
       return prompt;
    }
}
