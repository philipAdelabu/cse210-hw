/*
  Proverbs 3:5-6 Trust in the Lord with all thine heart and lean not unot thine 
                  own understanding; in lal lthy ways acknowleadge him, and he shall direct thy 
                  paths.
*/

public class Scripture {
    private Reference _reference;
    private List<Word> _words;
    private int _wordCount;
    private string _text; 

    public Scripture(Reference reference, string text){
        _reference = reference;
        _text = text;
        Text txt = new Text(text);
        _words = txt.GetWordList();
        _wordCount = txt.GetWordCount();
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

        for (int i = 1; i <= number; i++)
        {
            int rand = NextIndex(_words);
            string hide = ChangeCharacters(_words[rand].GetText());
            _words[rand].SetHideText(hide);
         } 
       return;
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


    private string ChangeCharacters(string wd)
    {
        string characters = "";
        foreach(char c in wd)
        {
            if (c == ',' || c == '.') continue; 
            characters += "_";
        }
        return characters;
    }

    public int VisibleWords(){
         int count = 0;
         foreach(Word word in _words){
            if(word.IsHidden() == false) 
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
