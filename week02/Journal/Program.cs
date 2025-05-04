using System;
using System.ComponentModel.Design;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

// I added some extra points of creativity by changing the menu and adding an additional function. 
// Instead, the program requires you to load/create your journal file first before adding entries. 
// You can then choose to change that file if you wish later on
// I also added a "Delete Entry" function that will display each entry and you can enter the number
// that corresponds with the entry you'd like to remove. 



class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        static Journal InitJournal()
        {
            Journal journal1 = new Journal();
            Console.Write("Enter a new or existing file name you would like to work with: ");
            journal1._filename = Console.ReadLine();
            journal1.LoadFile();
            return journal1;
        }
        Journal loadedJournal;
        loadedJournal = InitJournal();

        int choice;
        bool choiceValid;

        while (true)
        {
            Console.WriteLine("Enter a number to select one of the follow options:");
            Console.Write("1. Add Entry\n2. View Journal\n3. Delete Entry\n4. Load new journal\n5. Exit\n");
            choiceValid = int.TryParse(Console.ReadLine(), out choice);
            if (!choiceValid)
            {
                Console.Write("Enter a valid option: ");
            }
            else
            {
                if (choice == 1)
                {
                    Entry entry = new Entry();
                    string newEntry = entry._newEntry;
                    loadedJournal.AddEntry(newEntry);
                    loadedJournal.SaveFile();
                }
                else if (choice == 2)
                {
                    loadedJournal.DisplayAll();
                }
                else if (choice ==3)
                {
                    loadedJournal.DeleteEntry();
                    loadedJournal.SaveFile();
                }
                else if (choice == 4)
                {
                    loadedJournal = InitJournal();
                }
                else if (choice == 5)
                {
                    break;
                }
            }
        }   
            
    }
        
}