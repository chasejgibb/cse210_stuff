using System;
using System.ComponentModel;
using System.Data;

public class Reference
{
    private string _book;
    private int _chapter, _startVerse, _endVerse;
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
        
    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else 
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }

    public (int, int) GetVerses()
    {
        return (_startVerse, _endVerse);
    }
}