using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity {
    
    List<string> _prompts;
    List<string> _questions;

    public ReflectingActivity() {
        _name = "\nReflecting Activity";
        _description = "\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

    }

    public void Run() {
        DisplayStartMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string prompt = GetRandomPrompt();
            Console.WriteLine(prompt);
            ShowSpinner(5);

            foreach (var question in _questions)
            {
                if (DateTime.Now >= endTime) break;
                Console.WriteLine(question);
                ShowSpinner(5);
            }
        }
        DisplayEndingMessage();

    }

    
    public string GetRandomPrompt()
    {
        Random _random = new Random();
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
        
    }

    public string GetRandomQuestion()
    {
        Random _random = new Random();
        int index = _random.Next(_questions.Count);
        return _questions[index];
        
    }

    public void DisplayPrompt() {
        
    }

    public void DisplayQuestion() {
        
    }

}