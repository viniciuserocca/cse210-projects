using System;
using System.IO;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        var choice = "";
        do 
        {
            DisplayPlayerInfo();

            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Delete Goal");
            Console.WriteLine("  7. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {   
                CreateGoal();
            }

            else if (choice == "2")
            {   
                ListGoalDetails();
            }

            else if (choice == "3")
            {
                SaveGoals();
            }

            else if (choice == "4")
            {
                LoadGoals();
            }

            else if (choice == "5")
            {
                RecordEvent();
            }

            else if (choice == "6")
            {
                DeleteGoal();
            }

            else if (choice == "7"){}

            else
            {
                Console.Clear();
                Console.WriteLine("** This option is not availible **");
            }
        }
        while (choice != "7");
    }

    public void DisplayPlayerInfo()
    {   
        Console.WriteLine(""); 
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        int number = 1;

        foreach (Goal goal in _goals)
        {   
            string details = goal.GetNameString();
            Console.Write($"{number}. ");
            Console.WriteLine(details);
            number++;
        }
    }

    public void ListGoalDetails()
    {   
        int number = 1;

        Console.Clear();
        Console.WriteLine("The goals are:");

        foreach (Goal goal in _goals)
        {   
            string details = goal.GetDetailsString();
            Console.Write($"{number}. ");
            Console.WriteLine(details);
            number++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goal = Console.ReadLine();

        if (goal != "1" && goal != "2" && goal != "3")
        {   
            Console.Clear();
            Console.WriteLine("** This option is not availible **");
        }
        else
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            if (goal == "1")
            {
                SimpleGoal s = new SimpleGoal(name, description, int.Parse(points), false);
                _goals.Add(s);
            }

            else if (goal == "2")
            {
                EternalGoal e = new EternalGoal(name, description, int.Parse(points));
                _goals.Add(e);
            }

            else if (goal == "3")
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                string target = Console.ReadLine();

                Console.Write("What is the bonus for accomplishing it that many times? ");
                string bonus = Console.ReadLine();

                ChecklistGoal c = new ChecklistGoal(name, description, int.Parse(points), 0, int.Parse(target), int.Parse(bonus));
                _goals.Add(c);
            }
        }
        Console.Clear();
    }

    public void RecordEvent()
    {   
        Console.Clear();
        ListGoalNames();

        Console.WriteLine();
        Console.Write("Which goal would you like to accomplish? ");
        string userInput = Console.ReadLine();

        int goal = int.Parse(userInput);
        goal --;

        var selectedGoal = _goals[goal];

        if (selectedGoal.IsComplete() == true)
        {
            Console.Clear();
            Console.WriteLine($"This goal is already accomplished!");
        }
        else
        {
            int points = selectedGoal.RecordEvent();
            _score += points;
            Console.Clear();
            Console.WriteLine($"Congratulations! You have earned {points} points!");
        }
    }

    public void SaveGoals()
    {    
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
            {   
                outputFile.WriteLine(_score);
                foreach (Goal g in _goals)
                {
                    outputFile.WriteLine($"{g}|{g.GetStringRepresentation()}");
                }
            }
        Console.Clear();
        Console.WriteLine("Yous list has been saved into a file!");
    }

    public void LoadGoals()
    {   
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            if (parts[0] == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);

                SimpleGoal s = new SimpleGoal(name, description, points, isComplete);
                _goals.Add(s);
            }

            else if (parts[0] == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                EternalGoal e = new EternalGoal(name, description, points);
                _goals.Add(e);
            }

            else if (parts[0] == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int amountCompleted = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);

                ChecklistGoal c = new ChecklistGoal(name, description, points, amountCompleted, target, bonus);
                _goals.Add(c);
            }
            else 
            {
                _score = int.Parse(parts[0]);
            }
        }
        Console.Clear();
        Console.WriteLine("Yous list has been loaded from a file!");
    }
    public void DeleteGoal()
    {
        Console.Clear();
        ListGoalNames();

        Console.WriteLine();
        Console.Write("Which goal would you like to remove? ");
        string userInput = Console.ReadLine();

        int goal = int.Parse(userInput);
        goal --;

        var selectedGoal = _goals[goal];

        _goals.Remove(selectedGoal);

        Console.Clear();
        Console.WriteLine("You deleted a goal!");
    }
}