using System;

public class PromptGenerator
{
    private Random _random = new Random();
    private string[] _prompts;

    public PromptGenerator()
    {
        _prompts = new string[] 
        {
            "If I had one thing I could do over today, what would it be?",
            "What was the best part of my day?",
            "Who was the most interesting person I interacted with today?",
            "What was the most challenging task I faced today?",
            "What made me smile today?",
            "Who did I spend the most time with today?",
            "What was the highlight of my work/school day?",
            "Did I learn something new today? If so, what?",
            "What was the most unexpected thing that happened to me today?",
            "What was my favorite meal or snack today?",
            "What activity brought me the most joy today?",
            "What was the most frustrating moment of my day?",
            "What was the weather like today, and did it affect my plans?",
            "Did I have any interesting conversations today? What were they about?",
            "Did I take any photos today? If so, of what?",
            "Did I exercise or engage in physical activity today?",
            "What task or responsibility did I procrastinate on today?",
            "What goal or task do I want to accomplish tomorrow based on today?",
            "What was the most memorable moment of my day?",
            "How did I feel overall about how today went?"
        };
    }

    public string Display()
    {
        int index = _random.Next(0, _prompts.Length);
        return _prompts[index];
    }
}

