using System;
using System.Text.Json;

public class Initialize
{
    public class SavedScriptures
    {
    public string book {get;set;}
    public int chapter{get;set;}
    public int start_verse {get;set;}
    public int end_verse {get;set;}
    public string text {get;set;}
    }

    public SavedScriptures GetScripture()
    {
        string _filename = "Scrips.json";
        string json = File.ReadAllText(_filename);
        List<SavedScriptures> LoadedScriptures = JsonSerializer.Deserialize<List<SavedScriptures>>(json);

        for (int i = 0; i < LoadedScriptures.Count; i ++)
        {
            int _iRead = i + 1;
            if (LoadedScriptures[i].end_verse == 0)
            {
                Console.WriteLine($"""
                Option {_iRead}:
                    {LoadedScriptures[i].book} {LoadedScriptures[i].chapter}:{LoadedScriptures[i].start_verse}
                """);
            }
            else 
            {
                Console.WriteLine($"""
                Option {_iRead}:
                    {LoadedScriptures[i].book} {LoadedScriptures[i].chapter}:{LoadedScriptures[i].start_verse}-{LoadedScriptures[i].end_verse}
                """);
            }    
        }
        Console.Write("Enter a number corresponding with the scripture you'd like to memorize: ");
        int _choice = int.Parse(Console.ReadLine());
        return LoadedScriptures[_choice - 1];
    }
}






