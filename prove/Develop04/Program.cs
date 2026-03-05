using System;
// I made sure no random prompts/questions are selected until they have all been used at least once in that session.
// It works for the Reflection and Listing Activities.

// Also added animations for when the user enters an invalid digit in the main menu.
class Program
{
    static void Main(string[] args)
    {
        string _input;
        Activity a1 = new Breathing("Breathing", "This activity will help you RELAX. Clear your mind and focus on your breathing.");
        Activity a2 = new Reflection("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.");
        Activity a3 = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Console.WriteLine("Hello Develop05 World!");

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing Activity");
            Console.WriteLine("2. Start reflecting Activity");
            Console.WriteLine("3. Start listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu:");
            _input = Console.ReadLine();

            try
            {
                if (int.Parse(_input) == 1)
                {
                    Console.Clear();
                    int t = a1.DisplayWelcomeMessage();

                    Console.Clear();
                    Breathing ba = (Breathing)a1;
                    ba.StartActivity(t);

                    a1.DisplayEndMessage(t);
                    Console.Clear();
                }
                else if (int.Parse(_input) == 2)
                {
                    Console.Clear();
                    int t = a2.DisplayWelcomeMessage();

                    Console.Clear();
                    Reflection ra = (Reflection)a2;
                    ra.StartActivity(t);

                    a2.DisplayEndMessage(t);
                    Console.Clear();            
                }
                else if (int.Parse(_input) == 3)
                {
                    Console.Clear();
                    int t = a3.DisplayWelcomeMessage();

                    Console.Clear();
                    Listing la = (Listing)a3;
                    la.StartActivity(t);

                    a3.DisplayEndMessage(t);
                    Console.Clear();    
                }
                else if (int.Parse(_input) == 4)
                {
                    break;
                }
                else
                {
                    Activity a = new Activity();

                    Console.WriteLine();
                    Console.WriteLine("Try a number from 1 to 4!");
                    a.DisplayAnimation02(4);
                    Console.WriteLine();
                }
            }
            catch (System.FormatException)
            {
                Activity a = new Activity();

                Console.WriteLine();
                Console.WriteLine("Try using a number");
                a.DisplayAnimation02(4);
                Console.WriteLine();
            }

        }
    }
}