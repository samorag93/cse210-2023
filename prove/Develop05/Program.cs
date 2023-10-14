using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static List<Objective> objectives = new List<Objective>();
    
    static int userPoints = 0;

    static void Main(string[] args)
    {
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"You have {userPoints} points");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Seleccionar una opción del menú: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        CreateObjective();
                        break;
                    case 2:
                        ListObjectives();
                        break;
                    case 3:
                        Console.Write("What is the file name: ");
                        string fileName = Console.ReadLine();
                        SaveObjectivesToFile(fileName);
                        break;
                    case 4:
                        Console.Write("What is the file name: ");
                        string loadFile = Console.ReadLine();
                        LoadObjectivesFromFile(loadFile);
                        break;
                    case 5:
                        RegisterEvent();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Enter a number from 1 to 6.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid option. Enter a number from 1 to 6.");
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }

    public static void CreateObjective()
    {
        Console.Clear();
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. CheckListGoal");
        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());
        Console.Write("What is the name of your goal? ");
        string nameGoal = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int reward = int.Parse(Console.ReadLine());

        

        Objective objective = null;

        switch (choice)
        {
            case 1:
                objective = new SimpleObjective(nameGoal, description, reward);
                break;
            case 2:
                objective = new EternalObjective(nameGoal,description, reward);
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int targetCount = int.Parse(Console.ReadLine());
                objective = new ChecklistObjective(nameGoal, description, reward, targetCount);
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }

        if (objective != null)
        {
            objectives.Add(objective);
            Console.WriteLine("Goal created successfully...");
        }
    }

    static void ListObjectives()
    {
        Console.Clear();
        Console.WriteLine("The goals are:");
        for (int i = 0; i < objectives.Count; i++)
        {
            var objective = objectives[i];
            string status = objective.IsCompleted ? "[X]" : "[ ]";
            string additionalInfo = "";

            if (objective is ChecklistObjective checklistObjective)
            {
                additionalInfo = $"-- Currently completed: ({checklistObjective.CompletedCount}/{checklistObjective.TargetCount})";
            }

            Console.WriteLine($"{i + 1}. {status} {objective.Name} ({objective.Description}) {additionalInfo}");
        }
        Console.WriteLine($"\nYou have {userPoints} points");
    }

    static void SaveObjectivesToFile(string fileName)
    {
        Console.Clear();
        

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine($"{userPoints}");
            foreach (var objective in objectives)
            {
                string additionalInfo = "";
                if (objective is ChecklistObjective checklistObjective)
                {
                    additionalInfo = $"//{checklistObjective.CompletedCount}/{checklistObjective.TargetCount}";
                }
                writer.WriteLine($"{objective.GetType().Name}: {objective.Name} // {objective.Description} // {objective.GetReward()} {additionalInfo}");
            }
            
        }

        Console.WriteLine($"Goals saves in '{fileName}'...");
    }

    static void LoadObjectivesFromFile(string fileName)
    {
        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                objectives.Clear();
                
                while(!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    
                    string[] parts = line.Split(new string[] { ": ", " // " }, StringSplitOptions.None);                
                    if (parts.Length >= 3)
                    {
                        string goalType = parts[0];
                        string goalName = parts[1];
                        string description = parts[2];
                        if (goalType == "SimpleObjective" || goalType == "EternalObjective" || goalType == "ChecklistObjective")
                        {
                            
                            if (int.TryParse(parts[3].Replace(" // ", ""), out int points))
                            {
                                if(goalType == "SimpleObjective")
                                {
                                    objectives.Add(new SimpleObjective(goalName,description,points));
                                } 
                                else if (goalType == "EternalObjective")
                                {
                                    objectives.Add(new EternalObjective(goalName, description, points));
                                }
                                else if (goalType == "ChecklistObjective")
                                {
                                string[] subparts = parts[4].Split(',');

                                List<int> subgoals = new List<int>();

                                foreach (var subpart in subparts)
                                {
                                    if (int.TryParse(subpart, out int subgoalPoints))
                                    {
                                        subgoals.Add(subgoalPoints);
                                    }
                                }

                                objectives.Add(new ChecklistObjective(goalName, description, points, subgoals.ToArray()));
                            }
                        }
                    }
                }
            }
        }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error loading: {ex.Message}");
        }
    }

    public static void RegisterEvent(){
        Console.WriteLine("The goals are:");
        ListObjectives();
        Console.Write("Which goal did you accomplish? ");
        int selectedGoal;
        if (int.TryParse(Console.ReadLine(), out selectedGoal) && selectedGoal >= 0 && selectedGoal < objectives.Count)
        {
            Objective goal = objectives[selectedGoal];
            if(!goal.IsCompleted)
            {                
                if(goal is ChecklistObjective checklistObj)
                {
                    checklistObj.CompleteObjective();
                    if(checklistObj.CompletedCount < checklistObj.TargetCount)
                    {
                        userPoints += checklistObj.RewardPerCompletion;
                        Console.WriteLine($"Congratulations! You have win {checklistObj.RewardPerCompletion} points");
                        Console.WriteLine($"You now have {userPoints} points");
                    }
                }
                else if (goal is EternalObjective eternal)
                {
                    userPoints += eternal.RewardPerCompletion;
                    Console.WriteLine($"Congratulations! You have win {eternal.RewardPerCompletion} points");
                    Console.WriteLine($"You now have {userPoints} points");
                }
                else if (goal is SimpleObjective simple)
                {
                    userPoints += simple.GetReward();
                    Console.WriteLine($"Congratulations! You have win {simple.Reward} points");
                    Console.WriteLine($"You now have {userPoints} points");
                }
            }
            else
            {
                Console.WriteLine("Goal already registered");
            }
        }
    }
}
