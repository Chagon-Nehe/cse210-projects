// The Video class abstracts the details of a single video.
// It manages the video's metadata (title, author, length) and
// a list of its associated Comment objects.
public class Video
{
    // Private fields for encapsulation
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments; // This demonstrates composition: a Video "has a" list of Comments

    // Constructor to initialize a new video and its comment list
    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }

    // Method to add a new comment to the video's comment list
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to return the number of comments, abstracting the internal
    // list count from the user of the class.
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
    
    // Public getter methods for video properties
    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLengthInSeconds()
    {
        return _lengthInSeconds;
    }
    
    // Method to get the list of comments
    public List<Comment> GetComments()
    {
        return _comments;
    }
}