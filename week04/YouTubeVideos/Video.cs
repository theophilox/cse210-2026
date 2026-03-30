public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int GetCommentCount()
    
    {
        return _comments.Count;
    }


    public void DisplayComments()
    {
        foreach (Comment c in _comments)
        {
            c.DisplayComment();
        }
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comments: {GetCommentCount()}");
        DisplayComments();
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("");

    }
}