using System;

class Program
{
    static void Main(string[] args)
    {
       
       
        int guess = -1;
        int guessCount = 0;
        string autoPlay = "Yes";

        while (autoPlay != "No" && autoPlay != "no" && autoPlay != "NO" ) 
        {  
           
            
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 11);
            Console.Write("Enter your number guess: ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
                guessCount += 1;
            }
            else if ( guess < magicNumber)
            {
                Console.WriteLine("Higher");
                guessCount += 1;
            }
            else
            {
                Console.WriteLine($"You guess {guessCount} until you guess the right magic number");
                guessCount += 1;
                Console.WriteLine("Do you want to Play again?(Yes/No): ");
                autoPlay = Console.ReadLine();
                guessCount = 0;

                if ( autoPlay == "No" && autoPlay == "no" && autoPlay == "NO")
                {
                    
                    Console.WriteLine("Thank you for playing.");
                }
            }
  
        }
        
    }
}