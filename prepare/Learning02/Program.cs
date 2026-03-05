using System;

class Program
{
    static void Main(string[] args)
    {
        Resume myResume = new Resume();
        myResume._name = "Joe";

        while (true)
        {
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1. Add a Job");
            Console.WriteLine("2. Display Resume");
            Console.WriteLine("3. Add Education");
            Console.WriteLine("4. Quit");

            string response = Console.ReadLine();

            if (response == "1" || response == "job") {

                Job currentJob = new Job();
                Console.WriteLine("Insert Job Title: ");
                currentJob._title = Console.ReadLine();
                Console.WriteLine("Insert Start date: ");
                currentJob._startDate = Console.ReadLine();
                Console.WriteLine("Insert End date: ");
                currentJob._endDate = Console.ReadLine();

                myResume._experience.Add(currentJob);
            } 
            else if (response == "2")
            {
                myResume.DisplayFullResume();
            }
            else if (response == "3")
            {
                Education currentEdu = new Education();
                
                Console.WriteLine("Type the name of your school: ");
                currentEdu._school = Console.ReadLine();
                Console.WriteLine("Type the title/certificate name: ");
                currentEdu._titleEarned = Console.ReadLine();

                myResume._education.Add(currentEdu);
            }
            else if (response == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Try a number from 1 to 4!");
            }
        }
    }
}