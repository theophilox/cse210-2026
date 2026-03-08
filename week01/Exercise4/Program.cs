using System;

class Program
{
    static void Main(string[] args)
    {
     List<int> numbers = new List<int>();
        
        // Please note we could use a do-while loop here instead
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            // Only add the number to the list if it is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Part 1: Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        int count = numbers.Count;

        float average = ((float)sum) / count;

        Console.WriteLine($"The average is: {average}");
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
    
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

        int min = 999;

        foreach (int number in numbers)
        {
            if (number > 0 && number < min)
            {
    
                min = number;
            }
        }

        Console.WriteLine($"The smallest  positive number is: {min}");

        numbers.Sort();
        Console.WriteLine("Sorted list:");

        foreach ( int number in numbers)
        {
            Console.WriteLine(number);
        }

 


    }
}