using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video1 = new Video("Lion Heart", "Jean Claud Vadam", 5800);
        Video video2 = new Video("Titanic", "Micheal Brown", 4230);
        Video video3 = new Video("Shreck", "Tony Jackson", 10500);

        video1.AddComment(new Comment("Phil Collins", "This movie is nice, but needed more disciption."));
        video1.AddComment(new Comment("Samuel Toni", "Very good ending of the last part. I love the fact that it is very short."));
        video1.AddComment(new Comment("Suzan Broklin", "I never know that the ending could be so borring."));
        video1.AddComment(new Comment("Collins Bulton", "This movie is nice. I like it so much"));


        video2.AddComment(new Comment("Tony Blais", "This movie is nice, but needed more disciption."));
        video2.AddComment(new Comment("Shade Follaran", "I could not tell the reason why the directors did it this way."));
        video2.AddComment(new Comment("Opara Florance", "Who said the movie is not interesting. I actually like the way the main character left the scene of destruction."));

        video3.AddComment(new Comment("Hassan Jolly", "It is one of the most looked for movie of the year."));
        video3.AddComment(new Comment("James Christ", "This was a nice movie, but i expected more from it."));
        video3.AddComment(new Comment("Phil Collins", "I like it. It is a great"));
        video3.AddComment(new Comment("Polin Texa", "The worst movie of the year."));
       
       List<Video> videos = [video1, video2, video3];
       int counter = 1;
       foreach(Video video in videos){
            Console.WriteLine($"\n======== Video {counter++} ===========");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComment()}");
            List<Comment> videoComments = video.GetCommentList();
            if(videoComments.Count > 0)
            foreach(Comment comment in videoComments)
                 Console.WriteLine($"{comment.GetAuthor()} : {comment.GetComment()}");
            
       }
    }
}