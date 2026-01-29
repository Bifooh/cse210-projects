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

            if (response == "1") {

                Job job1 = new Job();
                job1._title = "Software Developer";
                job1._startDate = "Jan 02 2003";
                job1._endDate = "Feb 01 2008";

                myResume._experience.Add(job1);
            } 
            else if (response == "2")
            {
                Console.WriteLine(myResume);
            }
            else if (response == "3")
            {
                Education ed1 = new Education();
                ed1._school = "Instituto Politecnico";
                myResume._education.Add(ed1);
            }
            else if (response == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Try again!");
            }
        }
    }
}