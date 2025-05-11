using System;
using System.Data;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        var (_startVerse, _endVerse) = _reference.GetVerses();
        string[] splitText = text.Split(' ');

        if (_endVerse == 0) // Checks if there are multiple verses or not
        {
            _words.Add(new Word($"{splitText[0]}", false, false));
            foreach (string word in splitText.Skip(1))
            {
                AddWord(word);
            }
        }
        // End of logic if there's only 1 verse
        // Start of 2 verse logic
        // Will first make a range of numbers of all the verse numbers there are
        // Will then check if each word is equal to the next verse number
        // If it is, then it will first add "\n" then the number afterwards so it's nicely formatted
        else
        {
            List<string> verses = new List<string>();
            for (int i = _startVerse; i <= _endVerse; i ++)
            {
                verses.Add(Convert.ToString(i));
            }

            foreach (string word in splitText)
            {
                if (verses.Contains(word)) // Cgecks if the current string is in the list of verse numbers
                {
                    _words.Add(new Word($"\n{word}", false, false));
                }
                else
                {
                    AddWord(word);
                }
            }
        }
    }
    
    public void HideRandomWords()
    {
        int newHiddenWords = 0;
        int defaultToHide;
        bool allHidden;

        (allHidden, defaultToHide) = CheckIfAllHidden();
        while (newHiddenWords < defaultToHide)
        {
            Random rand = new Random();
            int index = rand.Next(1, _words.Count); // Randomly select an index to try and hide the word
            if (_words[index].GetIsWord())
            {
                if (!_words[index].GetIsHidden())
                {
                    _words[index].SetIsHidden();
                    newHiddenWords ++;
                }
            }
            
        }
        
    }

    public (bool, int) CheckIfAllHidden()
    {   
        int notHidden = 0;
        foreach (Word item in _words)
        {
            if (item.GetIsWord())
            {
                if (!item.GetIsHidden())
                {
                    notHidden ++;
                }
            }
        }
        if (notHidden == 0)
        {
        Console.WriteLine("All words hidden! Now exiting program");
        Environment.Exit(0);
        return (true, 0);
        }
        else if (notHidden > 0 && notHidden < 3)
        {return (false, notHidden);}
        else
        {return (false, 3);}
    }

    public void AddWord(string word)
    {
        if (word.Any(char.IsPunctuation)) // Checks if the word has punctuation or not
        {
            string _wordOnly = word.Substring(0, word.Length - 1); // Will add everything but the last character to the list
            string _punctuation = word.Substring(word.Length - 1);
            _words.Add(new Word(_wordOnly));
            _words.Add(new Word(_punctuation, false, false));

        }
        else
        {
            _words.Add(new Word(word));
        }
    }

    public string GetDisplayText()
    {
        string _totalText = "";
        foreach (Word word in _words)
        {
            
            if (!word.GetIsWord())
            {
                _totalText = _totalText.Trim();
            }
            _totalText += word.GetDisplayText();
            _totalText += " ";
        }
        return _totalText;
    }

}