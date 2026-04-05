using System;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");


        int choice = 0;

        while (choice != 4)
        {   
            Console.WriteLine("");
            Console.WriteLine("~~~~~~~~Menu Options~~~~~~~~");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());


            if (choice == 1)
            {
                BreathingActivity b1 = new BreathingActivity();
                b1.Run();
            }

            else if (choice == 2)
            {
                ReflectingActivity r1 = new ReflectingActivity();
                r1.Run();
            }

            else if (choice == 3)
            {
                ListingActivity l1 = new ListingActivity();
                l1.Run();
            }
            else if (choice == 4)
            {
                Console.WriteLine("");
                Console.WriteLine("Have a nice day ahead.");
                Console.WriteLine("Bye.");
                break;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Please Choose 1-4 Only");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("");
    
            }

        } 

    }
}