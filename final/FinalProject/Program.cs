using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<User> _users = new List<User>();
        WorkOutArchive wa = new WorkOutArchive();
        int _menuInput;

        while (true)
        {
            Console.WriteLine("\nMenu of options:");
            Console.WriteLine("1. Create new User");
            Console.WriteLine("2. Load User");
            Console.WriteLine("3. Add Workout Session");
            Console.WriteLine("4. Show Workout History");
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
                Console.WriteLine("User created successfully!");
            }
            else if (_menuInput == 2)
            {
                Console.WriteLine("Enter your User ID:");
                int searchId = int.Parse(Console.ReadLine());
                User loadedUser = AccessUser(_users, searchId);

                if (loadedUser != null)
                {
                    Console.WriteLine($"Information about {loadedUser.GetName()} loaded successfully.");
                }
                else
                {
                    Console.WriteLine("User not found. Please try a different ID or create a new user.");
                }
            }
            else if (_menuInput == 3)
            {
                Console.WriteLine("Which exercise did you complete? (1) Cardio or (2) Strength");
                int exType = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the name of the exercise (e.g., Running, Bench Press):");
                string exName = Console.ReadLine();

                Console.WriteLine("Enter estimated calories burnt:");
                float calories = float.Parse(Console.ReadLine());

                if (exType == 1)
                {
                    Console.WriteLine("Enter duration in minutes:");
                    int time = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter intensity (1-10):");
                    int intensity = int.Parse(Console.ReadLine());

                    Cardio cardio = new Cardio(time, intensity, exName, calories);
                    wa.AddExercise(cardio);
                    Console.WriteLine("Cardio workout added and saved!");
                }
                else if (exType == 2)
                {
                    Console.WriteLine("Enter number of reps:");
                    int reps = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter weight used (lbs):");
                    int weight = int.Parse(Console.ReadLine());

                    // Note: Continuing to use your spelling 'Strength' to match your class name
                    Strength Strength = new Strength(reps, weight, exName, calories);
                    wa.AddExercise(Strength);
                    Console.WriteLine("Strength workout added and saved!");
                }
            }
            else if (_menuInput == 4)
            {
                wa.DisplayHistory();
            }
            else if (_menuInput == 5)
            {
                Console.WriteLine("Goodbye!");
                break;
            }
        }
    }

    static public User AccessUser(List<User> users, int id)
    {
        foreach (User u in users)
        {
            if (u.GetId() == id)
            {
                return u;
            }
        }
        return null; // Return null if user isn't found
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