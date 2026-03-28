using System;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        List<User> _users = new List<User>();
        WorkOutArchive wa = new WorkOutArchive();
        User u = new User();
        int _menuInput;

        while (true)
        {
            Console.WriteLine("Menu of options:");
            Console.WriteLine("1. Create new User");
            Console.WriteLine("2. Load User");
            Console.WriteLine("3. Add Workout Session");
            Console.WriteLine("4. Load Workout History");
            Console.WriteLine("5. Quit");
            _menuInput = int.Parse(Console.ReadLine());

            if (_menuInput == 1)
            {
                // Getting ID/ PIN for the users
                Console.WriteLine("What do you want your 'id' to be? You will use this 'id' to access your information (use ONLY numbers, eg.'0254')");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("What is your name?");
                string userName = Console.ReadLine();
                Console.WriteLine("How old are you? (e.g. '90')");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("How much do you weight in lbs? (e.g. '175.5')");
                float lbs = float.Parse(Console.ReadLine());
                Console.WriteLine("What is you height in cms? (e.g. '180')");
                float height = float.Parse(Console.ReadLine());
                // Getting gender
                Console.WriteLine("What is you gender? (use 'm' for male or 'f' for female)");
                string gStrg = Console.ReadLine();
                bool gender = false;
                if (gStrg == "m" || gStrg == "male")
                {
                    gender = true;
                }
                // Deciding if the User's Fitness Goal will be WeightLoss or MuscleGain
                Console.WriteLine("What would your perfect body weight be? ");
                float perfectWeight = float.Parse(Console.ReadLine());
                Goal g = GetFitnessGoal(perfectWeight, lbs);
                User newUser = new User(id, userName, age, lbs, height, gender, g, wa);
                // Add user to the list of users
                _users.Add(newUser);

            }
            else if (_menuInput == 2)
            {
                // Load information about a user from the file with user or list of users
                // and then show information or a message saying "information about Samuel loaded"
            }
            else if (_menuInput == 3)
            {
                // Adding an exercise acomplished to a WorkOut Session either Cardio or Strengh to the Workout history
            }
            else if (_menuInput == 4)
            {
                // Loading  the Workout History and showing previous Workout Sessions.
            }
            else if (_menuInput == 5)
            {
                break;
            }
        }



    }

    public void AccessUser()
    {
        // Retrieve information from a specific user in the _users List
    }

    static public Goal GetFitnessGoal(float pw, float w)
    {
        if (pw >= w)
        {
            Goal userGoal = new MuscleGain(0, pw, w);
            return userGoal;
        }
        else
        {
            Goal userGoal = new WeightLoss(0, pw, w);
            return userGoal;
        }
    }
}