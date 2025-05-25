public class Word{
    private bool _isHidden;
    private string _hideText;
    private string _text;

    public Word(string text){
         _text = text;
         _isHidden = false;
    }

    public bool IsHidden(){
         return _isHidden;
    }
    public string GetDisplayText(){
        if(_isHidden == true)
            return _hideText;
        return _text;
    }

    public string GetText(){
        return _text;
    }

    public void SetHideText(string hideText){
        _hideText = hideText;
        _isHidden = true;
    }
 
  
}
