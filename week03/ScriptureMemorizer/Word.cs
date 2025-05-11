using System;
using System.Diagnostics.Contracts;

public class Word
{
    private string _text;
    private bool _isHidden, _isWord;

    public Word (string scriptureText, bool hidden = false, bool isWord = true)
    {
        _text = scriptureText; 
        _isHidden = hidden;
        _isWord = isWord;
    }

    public string Hide()
    {
        int _wordLength = _text.Length;
        return new string('_', _wordLength);;
    }

    public string GetDisplayText()
    {
        if (_isWord && _isHidden)
        {
            return Hide();
        }
        else
        {
            return _text;
        }

    }

    public bool GetIsWord()
    {
        return _isWord;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public void SetIsHidden()
    {
        _isHidden = true;
    }
}