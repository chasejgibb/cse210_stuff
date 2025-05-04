using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public string _filename;
    public List<string> _entries = new List<string>();
    public string _currentEntry = "";

    public void LoadFile()
    {
        if (File.Exists(_filename))
        {
            string[] lines = System.IO.File.ReadAllLines(_filename);
            foreach (string line in lines)
            {
                _currentEntry += ($"{line}\n");
                if (line == "-")
                {
                    _entries.Add(_currentEntry);
                    _currentEntry = "";
                }
                
            }
            Console.WriteLine("File located and loaded.");
        }
        else if (!File.Exists(_filename))
        {
            Console.WriteLine("Creating new file.");
            _entries.Clear();
            SaveFile();
        }
    }

    public void SaveFile()
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
            {
                foreach (string line in _entries)
                {outputFile.WriteLine(line);}
            }
    }
    
    public void DisplayAll()
    {
        Console.WriteLine("--------");
        foreach (string line in _entries)
        {
            Console.WriteLine(line);
        }
        Console.WriteLine("--------");
    }

    public void AddEntry(string newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DeleteEntry()
    {
        int counter = 1;
        int index;
        foreach (string item in _entries)
        {
            Console.WriteLine($"Entry #{counter}: {item}");
            counter++;            
        }
        Console.WriteLine("Enter the number corresponding with the entry you'd like to remove");
        index = int.Parse(Console.ReadLine());
        _entries.RemoveAt(index - 1);
    }   
}

// store running input from entries in newEntries
//
// possible issues: trying to save without a file... Could ask on startup for a file to work with.
//
// if the newEntries variable contains content, will ask if you would like to save before exiting... Will automatically save everything?
// 
// Display will show current unsaved entries and the saved journal file
//
// You can choose to load a different file within the interface without exiting the program