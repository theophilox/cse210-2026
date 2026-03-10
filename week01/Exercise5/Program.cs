using System;
using System.Globalization;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int sqt = SquareNumber(number);

        DisplayResult(name, sqt);
        
    }
    static void DisplayWelcome()
    {
            
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName ()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber ()
    {
        Console.WriteLine("Please enter your favorite number: ");
        string favorite = Console.ReadLine();
        int number = int.Parse(favorite);
        return number;
    }

    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }



    
}