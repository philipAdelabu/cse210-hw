

public class MultipleScripture {

   private Reference _reference;
   private Scriptures _books;
   private List<Scripture>  _scriptures;
   private string _text;
    private List<Word> _words;
       
        public MultipleScripture(Reference reference, int endVerse){

            _reference = new Reference(reference.GetBook(), reference.GetChapter(), reference.GetStartVerse(), endVerse);
            _books = new Scriptures();
            _scriptures = _books.GetSricptures();
            _text = GetMultipleVerse(reference.GetBook(), reference.GetChapter(), reference.GetStartVerse(), endVerse);
            Text txt = new Text(_text);
           _words = txt.GetWordList();

        }

        public string GetMultipleVerse(string book, int chapter, int startVerse, int endVerse){
         string text = "";
         bool start = true;
         int counter = startVerse;
           foreach(Scripture scripture in _scriptures ){
            if(counter > endVerse) break;
              Reference reference = scripture.GetReference();
              if(reference.GetBook() == book && reference.GetChapter() == chapter){
              if(reference.GetStartVerse() == startVerse && start == true){
                   
                    text += scripture.GetText();
                    start = false;
              }else{
                 text += scripture.GetText();
                 counter += 1;
              }
              }
          }
          return text;
    }

    public string HideRandomWords(int numberToHide = 2){
        if(IsCompletelyHidden() == false)
               HideRandom(numberToHide);
      string refr = _reference.GetDisplayText();
      string text =  ListToWords();
      return $"{refr} {text}"; 
    }

    public string GetDisplayText(){
        string refr = _reference.GetDisplayText();
        string text = _text.Trim('"');
       return $"{refr} {text}";  
    }

    public bool IsCompletelyHidden(){
      foreach(Word word in _words)
         if(word.IsHidden() == false) 
             return false;
       return true;
    }

    private void HideRandom(int number){
        int visibleWords = VisibleWords();
        if(visibleWords == 0) return ;
        if(number > visibleWords) number = visibleWords;
   
       for(int i = 1; i <= number; i++){
                  int rand = NextIndex(_words);
            string hide = ChangeCharacters(_words[rand].GetText());
            _words[rand].SetHideText(hide); 
         } 
       return;
    }


    private string ChangeCharacters(string wd){
        string characters = "";
          foreach(char c in wd){
                 if (c == ',' || c == '.' ||  c == ':' || c == ';' || c == '!' || c == '?'){
                 characters += c;
                 return characters;
                 } 
            else
            characters += "_";
        }
        return characters;
    }
    
       private int NextIndex(List<Word> words)
    {
         Random random = new Random();
        int lastIndex = words.Count - 1;
        List<int> unHiddenWors = new List<int>();
        for (int i = 0; i <= lastIndex; i++)
        {
            if (words[i].IsHidden() == false)
                unHiddenWors.Add(i);
        }
        if (unHiddenWors.Count == 0) return 0;
        int rand = random.Next(0, unHiddenWors.Count - 1);
        return unHiddenWors[rand]; 
    }

    public int VisibleWords()
    {
        int count = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
                count += 1;
        }
        return count;
    }

    public string ListToWords(){
        string text = "";
        foreach(Word word in _words)
           text += (word.GetDisplayText().Trim('"')) + " ";
        string t = text.Trim('"');
        return t;
    }

    public Reference GetReference(){
        return _reference;
    }

    public string GetText(){
        return _text;
    }



}
