using System;
// Added a trhid type of goal, a long simple goal, which is like a simple goal but it can be worked towards multiple times to get points, or be marked as complete to get the points one last time.
class Program
{
    static void Main(string[] args)
    {
        List<Goal> _goals = new List<Goal>();
        int _totalPoints = 0;
        string filename = "myFile.txt";
        
        while (true)
        {
            // Console.Clear();
            Console.WriteLine($"You have {_totalPoints} points.");

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine(" 1. Simple Goal");
                Console.WriteLine(" 2. Eternal Goal");
                Console.WriteLine(" 3. CheckList Goal");
                Console.WriteLine(" 4. Long Simple Goal");
                Console.WriteLine("Which type of goal would you like to create? ");
                int goalTypeChoice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (goalTypeChoice == 1)
                {
                    Console.WriteLine("What is the name of your goal? "); 
                    string nam = Console.ReadLine();
                    Console.WriteLine("What is a short desciption of it? "); 
                    string desc = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? "); 
                    int poin = int.Parse(Console.ReadLine());

                    Goal g = new Simple(nam, desc, poin);
                    _goals.Add(g);
                }
                else if (goalTypeChoice == 2)
                {
                    Console.WriteLine("What is the name of your goal? "); 
                    string nam = Console.ReadLine();
                    Console.WriteLine("What is a short desciption of it? "); 
                    string desc = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? "); 
                    int poin = int.Parse(Console.ReadLine());

                    Goal g = new Eternal(nam, desc, poin);
                    _goals.Add(g);
                }
                else if (goalTypeChoice == 3)
                {
                    Console.WriteLine("What is the name of your goal? "); 
                    string nam = Console.ReadLine();
                    Console.WriteLine("What is a short desciption of it? "); 
                    string desc = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? "); 
                    int poin = int.Parse(Console.ReadLine());
                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus? "); 
                    int bonu = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the bonus for accomplishing it that many times? "); 
                    int exPoin = int.Parse(Console.ReadLine());

                    Goal g = new CheckList(nam, desc, poin, bonu, exPoin);
                    _goals.Add(g);
                }
                else if (goalTypeChoice == 4)
                {
                    Console.WriteLine("What is the name of your goal? "); 
                    string nam = Console.ReadLine();
                    Console.WriteLine("What is a short desciption of it? "); 
                    string desc = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? "); 
                    int poin = int.Parse(Console.ReadLine());

                    Goal g = new LongSimple(nam, desc, poin);
                    _goals.Add(g);
                }
                else
                {
                    Console.WriteLine("That is not a valid input. Please select a number from the menu.");
                    Console.WriteLine();
                }
            }
            else if (input == 2)
            {
                int n = 1;
                Console.WriteLine("The goals are: ");
                foreach (Goal g in _goals)
                {
                    Console.Write($"{n}. ");
                    g.DisplayGoal();
                    n += 1;
                }
                Console.WriteLine();
            }
            // Saving the goals to a file. It writes each goal's data to a line in the file, with the different pieces of data separated by commas.
            else if (input == 3)
            {
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (Goal g in _goals)
                    {
                        outputFile.WriteLine($"{g.GetName()},{g.GetDescription()},{g.GetPoints()},{g.GetStatus()},{g.GetExtraData()},{g.GetTypeOfGoal()}");
                    }
                }
                Console.WriteLine("Goals saved to file.");
                Console.WriteLine();
            }
            // Loading the goals from a file. It reads each line, splits it by the commas, and then uses the data to create the correct type of goal and add it to the list of goals.
            else if (input == 4)
            {
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");

                    string name = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);
                    bool status = bool.Parse(parts[3]);
                    int reps = int.Parse(parts[4]);
                    int repsGoal = int.Parse(parts[5]);
                    int bonusPoints = int.Parse(parts[6]);
                    string type = parts[7];

                    if (type == "Simple")
                    {
                        Goal g = new Simple(name, description, points);
                        if (status)
                        {
                            g.SetToDone();
                        }
                        _goals.Add(g);
                    }
                    // If the goal can never be done, then it is an eternal goal.
                    else if (type == "Eternal")
                    {
                        Goal g = new Eternal(name, description, points);
                        _goals.Add(g);
                    }
                    // If it has a reps goal greater than 0, then it is a checklist goal.
                    else if (type == "CheckList")
                    {
                        Goal g = new CheckList(name, description, points, repsGoal, bonusPoints);
                        for (int i = 0; i < reps; i++)
                        {
                            g.RecordEvent();
                        }
                        _goals.Add(g);
                    }   
                    else if (type == "LongSimple")
                    {
                        Goal g = new LongSimple(name, description, points);
                        if (status)
                        {
                            g.SetToDone();
                        }
                        _goals.Add(g);
                    }
                }
                Console.WriteLine("Goals loaded from file.");
                Console.WriteLine();
            }
            // Recording an event for a goal.
            else if (input == 5)
            {
                int n = 1;
                Console.WriteLine();
                Console.WriteLine("The goals are: ");
                foreach (Goal g in _goals)
                {
                    Console.Write($"{n}. ");
                    g.DisplayGoal();
                    n += 1;
                }

                Console.WriteLine("What goal did you acomplished? ");
                int whichGoal = int.Parse(Console.ReadLine());

                _goals[whichGoal - 1].RecordEvent();

                if (_goals[whichGoal - 1].GetTypeOfGoal() == "CheckList" && _goals[whichGoal - 1].GetStatus() == true)
                {
                    _totalPoints += _goals[whichGoal - 1].GetPoints() + _goals[whichGoal - 1].GetBonusPoints();
                    Console.WriteLine($"You got {_goals[whichGoal - 1].GetPoints()} points and {_goals[whichGoal - 1].GetBonusPoints()} as a bonus!");
                    Console.WriteLine();
                }
                else if (_goals[whichGoal - 1].GetTypeOfGoal() == "LongSimple" && _goals[whichGoal - 1].GetStatus() == false)
                {
                    _totalPoints += _goals[whichGoal - 1].GetPoints();
                    Console.WriteLine($"You got {_goals[whichGoal - 1].GetPoints()} points for working towards this goal!");
                    Console.WriteLine();
                }
                else
                {
                    _totalPoints += _goals[whichGoal - 1].GetPoints();
                    Console.WriteLine($"You got {_goals[whichGoal - 1].GetPoints()} points!");
                    Console.WriteLine();
                }

            }
            // Quitting the program.
            else if (input == 6)
            {
                break;
            }
            else
            {
                Console.WriteLine("That is not a valid input. Please select a number from the menu.");
                Console.WriteLine();
            }
        }
    }
}