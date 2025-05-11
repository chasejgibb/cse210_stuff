using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Initialize init = new Initialize();
        var scripture = init.GetScripture();
        
        Reference scripReference = new Reference(scripture.book, scripture.chapter, scripture.start_verse, scripture.end_verse);
        Scripture scriptureObj = new Scripture(scripReference, scripture.text);
        
        bool isValid = true;
        while (isValid)
        {
            Console.WriteLine("\nPress enter to continue. Otherwise, type 'quit' to exit the program.");
            string input = Console.ReadLine();
            if (input == "")
            {
                Console.Clear();
                Console.WriteLine(scripReference.GetDisplayText());
                Console.WriteLine(scriptureObj.GetDisplayText());
                scriptureObj.HideRandomWords();
            }
            else if (input == "quit")
            {
                isValid = false;
            }
            else
            {
                Console.WriteLine("Invalid input... Try using your eyes");
            }
        }

        
    }
}