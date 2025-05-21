using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;

public class Video
{
    private string _title, _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length, List<string> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
        foreach (string item in comments)
        {
            _comments.Add(new Comment(item));
        }
    }

    // feed _comments to Comment and have Comment iterate through and 

    

    public int NumberOfComments()
    {
        return _comments.Count();
    }

    public void Display()
    {
        Console.WriteLine($"Video Title: {_title} | Video Author: {_author} | Video Length: {_length / 60}:{_length % 60:D2}");
        // Found "D2" formatting here: https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
        Console.WriteLine("-----Comments-----");
        Console.WriteLine($"There are {NumberOfComments()} total comments.");
        foreach (Comment item in _comments)
        {
            item.Display();
        }
        
    }

}