using System;

public class Prompt
{
    public static Random _rand = new Random();
    List<string> _prompts = new List<string> { 
        "What made you smile today?", 
        "What is something you learned about yourself recently?",
        "What is one goal you want to work on tomorrow?",
        "What moment today would you like to remember in the future?",
        "What is a challenge you are currently facing?",
        "What is one good habit you want to develop?"};

    public string GeneratePrompt()

    {
        int index = _rand.Next(_prompts.Count);
        return _prompts[index];
    }
}