using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string> {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the best food I ate today?",
        "What was the most crazy thing that happened today?",
        "How was the climate today?",
        "If today was an animal, which one would it be?",
        "If today was a color, which one would it be?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);

        string prompt = _prompts[randomIndex];
        return prompt;
    }
}