using System;

class Program
{
    static void Main(string[] args)
    
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal myJournal = new Journal();
        
        int menuAnswer = 0;

        while (menuAnswer != 5)
        {
            Console.WriteLine("");
            Console.WriteLine("Hello, What do you want to do?");
            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Display my journal");
            Console.WriteLine("3. Load my journal");
            Console.WriteLine("4. Save my journal");
            Console.WriteLine("5. Bye.");
            Console.WriteLine("---------------------------------------");
            Console.Write("\nWhat would you like to do? ");

            menuAnswer = int.Parse(Console.ReadLine());


            if (menuAnswer == 1)
            {   
                Entry myEntry = new Entry();
                myEntry.WriteEntry();
                myJournal.AddEntry(myEntry);


            }
            else if (menuAnswer == 2)
            {

                Console.WriteLine("\n--------------------MY JOURNAL---------------------");
                myJournal.DisplayJournal();
            }
            else if (menuAnswer == 3)
            {

            }
            else if (menuAnswer == 4)
            {

            }
            else if (menuAnswer == 5)
            {
                Console.WriteLine("I'll be waiting to hear a great story from you again");
                Console.WriteLine("Bye.");
                break;
            }
            else
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("----------Pick a valid action.---------");
                Console.WriteLine("---------------------------------------");
            }
            
        } 

    }
    
}