
public class Entry {

    public string _date;
    public string _promptText;
    public string @_entryText;

      public Entry(string promptText, string entryText, string date){
           _date = date;
           _promptText = promptText;
           _entryText = entryText; 
   }

   
     public void Display(){
        Console.WriteLine($"Date: {_date}\nPrompt: {_promptText} \nEntry Text: {_entryText} \n");
     }
    
}
