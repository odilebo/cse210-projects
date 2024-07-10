public class PromptGenerator 
{
    public List<string> _prompts = new List<string>() {
            "What new thing did I learn today?",
            "What was the most challenging part of my day and how did I handle it?",
            "What is something I did today that I'm proud of?",
            "Who did I help or support today, and how did it make me feel?",
            "What is one thing I could have done to make today better?",
            "How did I practice self-care today?",
            "What was the most unexpected thing that happened today?",
            "How did I step out of my comfort zone today?",
            "What am I grateful for today?",
            "What is one thing I am looking forward to tomorrow?"

    };
    public string GetRandomPrompt()
    {
        Random _random = new Random();
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
        
    }
}