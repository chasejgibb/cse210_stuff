public class Comment
{
    private string _author, _text;

    public Comment(string comment)
    {
        string[] splitText = comment.Split(":");
        _author = splitText[0];
        _text = splitText[1];
    }

    public void Display()
    {
        Console.WriteLine($"Author: {_author}\nComment: {_text}\n");
    }
}