// The Comment class abstracts the details of a single comment.
// It hides the internal data representation and provides simple
// methods to access the commenter's name and the comment text.
public class Comment
{
    // Private fields for encapsulation
    private string _commenterName;
    private string _commentText;

    // Constructor to initialize a new comment
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    // Public getter methods to provide controlled access to private data
    public string GetCommenterName()
    {
        return _commenterName;
    }

    public string GetCommentText()
    {
        return _commentText;
    }
}