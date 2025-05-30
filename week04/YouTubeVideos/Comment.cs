public class Comment {
    private string _author;
    private string _comment;

    public Comment(string authorName, string comment){
        _author = authorName;
        _comment = comment;
    }

    public string GetAuthor(){
         return _author;
    }

    public string GetComment(){
        return _comment;
    }

}
