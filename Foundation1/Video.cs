public class Videos
{
    public string _title;
    public string _author;
    public int _length;
    public int _count;
    public List<Comments> _comments = new List<Comments>();
    
    public Videos(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void GetComments()
    {
        foreach(Comments comment in _comments)
        {
            comment.Display();
        }
    }
    public int GetCommentNum()
    {
        foreach(Comments commment in _comments)
        {
            _count += 1;
        }
        return _count;
    }
}