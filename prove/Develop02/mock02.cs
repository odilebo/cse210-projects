using System;
using System.Collections.Generic;
using System.IO;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>() 
    {
        "How are you doing?",
        "What did you do today?",
        "What's your favorite hobby?",
        "Have you read any good books lately?",
        "What's your favorite movie?",
        "What are your plans for the weekend?",
        "Do you have any pets?",
        "What's your favorite food?",
        "Where would you like to travel next?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}

public class Journal
{
    private List<string> _entries = new List<string>();

    public void AddEntry(string entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
        }
        else
        {
            foreach (var entry in _entries)
            {
                Console.WriteLine(entry);
            }
        }
    }

    public void SaveEntries(string filename)
    {
        File.WriteAllLines(filename, _entries);
        Console.WriteLine("Entries saved to " + filename);
    }

    public void LoadEntries(string filename)
    {
        if (File.Exists(filename))
        {
            _entries = new List<string>(File.ReadAllLines(filename));
            Console.WriteLine("Entries loaded from " + filename);
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program");

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string choice;

        do
        {
            Console.WriteLine("Please select one of the following: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            choice = Console.ReadLine();
            if (choice == "1") 
            {
                Console.WriteLine(promptGenerator.GetRandomPrompt());
                string entry = Console.ReadLine();
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayEntries();
            }  
            else if (choice == "3")
            {
                Console.WriteLine("Enter the filename to load:");
                string filename = Console.ReadLine();
                journal.LoadEntries(filename);
            }
            else if(choice == "4")
            {
                Console.WriteLine("Enter the filename to save:");
                string filename = Console.ReadLine();
                journal.SaveEntries(filename);
            }
            else if(choice == "5")
            {
                Console.WriteLine("Goodbye");
            }
            else 
            {
                Console.WriteLine("Invalid Choice");
            }
            Console.WriteLine();

        } while (choice != "5"); 
    }
}
