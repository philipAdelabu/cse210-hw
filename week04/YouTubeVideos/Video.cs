public class Video {
    private string _title;
    private string _author;
    private int _length;

    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length){
           _title = title;
           _author = author;
           _length = length;
    }

    public Video(string title, string author, int length, Comment comment){
           _title = title;
           _author = author;
           _length = length;
           _comments.Append(comment);
    }
    

    public int GetNumberOfComment(){
        return _comments.Count;
    }

    public string GetTitle(){
        return _title;
    }

    public string GetAuthor(){
        return _author;
    }

    public int GetLength(){
        return _length;
    }


    public List<Comment> GetCommentList(){
        return _comments;
    }

    public void AddComment(Comment comment){
        _comments.Add(comment);
    }



}
