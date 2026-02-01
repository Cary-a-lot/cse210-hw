using System;
using System.Collections.Generic;

class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the most random thought I had today?",
        "Did any past advice help you in your day today?",
        "What color of socks did you wear today?",
        "What steps did you take to get closer to your goals?",
        "How do you feel you have been doing mentally recently?",
        "What creative ideas have you had today?",
        "Has any of your favorites changed?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
