
public class Reference {
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    private bool _isMultipleVerse;
 

    public Reference(string book, int chapter, int startVerse){
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = 0;
        _isMultipleVerse = false;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse){
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _isMultipleVerse = true;
    }

    public string GetDisplayText(){
        if(_endVerse != 0)
             return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        return  $"{_book} {_chapter}:{_startVerse}";
    }

    public int GetEndVerse(){
        return _endVerse;
    }
      public int GetStartVerse(){
        return _startVerse;
    }
    public bool IsMultipleVerse(){
         return _isMultipleVerse;
    }

    public string GetBook(){ return _book; }
    public int GetChapter(){ 
        return _chapter;
         }





}
