using System;
using System.Collections.Generic;

public class ListingActivity : Activity {
    private int _count;
    List<string> _prompts;

    public ListingActivity() {
        _name = "Listing Activity";
        _count = 0;
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };


    }

    public void Run() {
        DisplayStartMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        ShowSpinner(5);

        List<string> items = GetListFromUser();

        Console.WriteLine($"\nYou listed {items.Count} items.");
        DisplayEndingMessage();

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
        
    }

    public List<string> GetListFromUser() 
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\n Enter an something but if you have nothing more to say. Type in done: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "done") break;
            items.Add(input);
        }
        return items;
    }

}