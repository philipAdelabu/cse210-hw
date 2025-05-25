
public class Text {


  private List<Word> _words = new List<Word>();
  private string _text;

  public Text(string text){
     _text = text;
  }
 
  private void WordToList(){
         string[] words = _text.Split(" ");
         foreach(string word in words){
          _words.Add(new Word(word));
         }
  }

  public List<Word> GetWordList(){
      WordToList();
     return _words;
  }

  public int GetWordCount(){
     return _words.Count;
  }
       

}