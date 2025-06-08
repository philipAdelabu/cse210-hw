
public class ListingActivity : Activity {
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description): base(name, description){}

    public void Run() {}

    public string GetRandomPrompt(){
        return "";
    }

    public void SetPrompt(List<string> prompts){
         _prompts = prompts;
    }
    
   public void SetCount(int count){
     _count = count;
   }
   public int GetCount(){
     return _count;
   }
}
