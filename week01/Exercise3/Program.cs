using System;

class Program
{
    static void Main(string[] args)
    {
       
       
        int guess = -1;
        int guessCount = 0;
        Boolean autoPlay = true;

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);

        while (autoPlay != false) 
        {  
           
            
           
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
                guessCount += 1;
                Console.WriteLine($"You guess {guessCount} until you guess the right magic number");
                Console.WriteLine("Do you want to Play again?(Yes/No): ");
                string answer = Console.ReadLine();
                string lowerCaseAnswer  = answer.ToLower();
                guessCount = 0;

                if ( lowerCaseAnswer == "no")
                {
                    autoPlay = false;
                    Console.WriteLine("Thank you for playing.");
                }
                else
                {

                    magicNumber = randomGenerator.Next(1, 11);
                }
            }
  
        }
        
    }
}