using System;

class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public int GetNumberOfComments(int video)
    {   
        int count = 0;
        foreach (Comment comment in _comments)
        {
            count++;
        }
        return count;
    }

    public void AddEntry(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayVideoInfo(int video)
    {   
        Console.WriteLine($"{_title} by {_author} ({_length} seconds)");

        int count = GetNumberOfComments(video);
        Console.WriteLine($"Comments ({count})");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComments();
        }

        Console.WriteLine();
    }
    
}