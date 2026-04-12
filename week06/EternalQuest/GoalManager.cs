public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Run()
    {
        Console.Clear();
        string menuChoice;

        while (true)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            DisplayPlayerInfo();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.Write("Select a choice from the menu: ");
            menuChoice = Console.ReadLine();

            if (menuChoice == "1")
                {
                    CreateGoal();
                }

                else if (menuChoice == "2")
                {
                    ListGoalDetails();
                }

                else if (menuChoice == "3")
                {
                    ShowSpinner(3);
                    SaveGoals();
                }

                else if (menuChoice == "4")
                {
                    ShowSpinner(3);
                    LoadGoals();
                }
                else if (menuChoice == "5")
                {
                    RecordEvent();
                }
                else if (menuChoice == "6")
                {
                    ShowSpinner(3);
                    Console.WriteLine("See you again and hope you complete more goal.");
                    Console.WriteLine("Bye.");
                    break;
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("Invalid Selection.");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
                }
            
        }       
        
    }    

    public void DisplayPlayerInfo()
    // Displays the players current score.
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    public void ListGoalDetails()
    // Lists the details of each goal by calling each goal's GetDetailString() method.
    {
        int count = 0;

        Console.WriteLine("\nThe goals are:");
        foreach (Goal goal in _goals)
        {
            count++;
            Console.WriteLine($"{count}. {goal.GetDetailString()}");
        }
    }
    public void CreateGoal()
    // Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    {

        while (true)
        {
            string userGoal;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\nSelect type of Goals: ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. Back");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.Write("Which type of goal would you like to create? ");
            userGoal = Console.ReadLine();

            if (userGoal != "1" && userGoal != "2" && userGoal != "3")
            {
                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Invalid Choice");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                continue;
            }
            else if (userGoal == "4") 
            {
                break;
            }

            Console.Write("\nWhat is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("\nWhat is a short description of your goal? ");
            string description = Console.ReadLine();

            Console.Write("\nHow many points do you want associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            if (userGoal == "1")
            {
                SimpleGoal s1 = new SimpleGoal(name, description, points);
                _goals.Add(s1);
            }

            else if (userGoal == "2")
            {
                EternalGoal e1 = new EternalGoal(name, description, points);
                _goals.Add(e1);
            }

            else if (userGoal == "3")
            {
                Console.Write("\nHow many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("\nWhat is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                ChecklistGoal c1 = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(c1);
            }

        }
        
    }

    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Which goal did you accomplish? ");
        int doneGoal = int.Parse(Console.ReadLine());

        Goal selected = _goals[doneGoal - 1];
        selected.RecordEvent();

        _score += selected.GetPoints();

        if (selected.IsComplete())
        {
            Console.WriteLine($"Congratulations! You have earned {selected.GetPoints()} points!");
        }
        Console.WriteLine($"You now have {_score} total points.");
        
    }

    public void SaveGoals()
    
    {
        
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string path = Path.Combine("..", "..", "..", filename);
        using (StreamWriter outputFile = new StreamWriter(path))
        {

            outputFile.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }

        }
    }
    
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string path = Path.Combine("..", "..", "..", filename);
        string[] pointCount = File.ReadAllLines(path);   
        int score = int.Parse(pointCount[0]);
        _score = score;
        
        string[] lines = File.ReadAllLines(filename).Skip(1).ToArray();
        foreach (string line in lines)
        {
            string[] parts = line.Split("::");
            string goalType = parts[0].Trim();
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (goalType == "Simple Goal")
            {
                string isComplete = parts[4];
                SimpleGoal s1 = new SimpleGoal(name, description, points);
                s1.SetComplete(Convert.ToBoolean(isComplete));
                _goals.Add(s1);
            }
            else if (goalType == "Eternal Goal")
            {
                EternalGoal e1 = new EternalGoal(name, description, points);
                _goals.Add(e1);
            }
            else if (goalType == "Checklist Goal")
            {
                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int completed = int.Parse(parts[6]);
                ChecklistGoal c1 = new ChecklistGoal(name, description, points, target, bonus);
                c1.SetAmountCompleted(completed);
                _goals.Add(c1);
            }
        }
    }


    public void ShowSpinner(int seconds)
    {
        List<string> animations = new List<string> {"|", "/", "-", "\\"};
        int i = 0;

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            string s = animations[i];
            Console.Write(s);
            Thread.Sleep(300);
            Console.Write("\b \b");
            i++;

            if (i >= animations.Count)
            {
                i = 0;
            }
        }
        
    }
}