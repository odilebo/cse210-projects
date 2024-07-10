public class PromptGenerator 
{
    public List<string> _prompts = new List<string>() {
        "How are you doing?",
        "What did you do today?",
        "What's your favorite hobby?",
        "Have you read any good books lately?",
        "What's your favorite movie?",
        "What are your plans for the weekend?",
        "Do you have any pets?",
        "What's your favorite food?",
        "Where would you like to travel next?",

    };
    public string GetRandomPrompt()
    {
        Random _random = new Random();
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
        
    }
}