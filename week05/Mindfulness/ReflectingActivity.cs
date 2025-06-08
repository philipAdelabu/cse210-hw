public class ReflectingActivity : Activity {
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description):base(name, description){}

    public void Run(){}
       public string GetRandomPrompt(){
        return "";
    }
      public void SetPrompt(List<string> prompts){
         _prompts = prompts;
    }

    public void SetQuestions(List<string> questions){
          _questions = questions;
    }
    public string GetRandomQuestion(){
        return "";
    }
    public void DisplayPrompt(){

    }
    public void DisplayQuestions(){}

}
