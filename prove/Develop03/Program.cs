using System;
/* 

- Added aditional options on the menu to be able to filter entries by date, so that the user can see entries only from an especific day 
- Added entries counter when option 2 is used (Show current journal page shows current entries)

*/


class Program
{

    static void Main(string[] args)
    {
        Journal usersJournal = new Journal();
        
        while (true)
        {
            Console.WriteLine("Choose what to do next: ");
            Console.WriteLine("1. Write something new");
            Console.WriteLine("2. Show current journal page");
            Console.WriteLine("3. Save page on Jounal");
            Console.WriteLine("4. Load Complete Journal");

            // Adding a way to load the journal and filter part of it to show only entries on especific date
            Console.WriteLine("5. Find Page on saved Journal");
            Console.WriteLine("6. Quit");

            string response = Console.ReadLine();

            // Create Journal Entry
            if (response == "1") {

                JournalEntry je = new JournalEntry();
                je.CreateJournalEntry();

                usersJournal._pages.Add(je);
                
            } 
            // Display the current Journal pages (list of entries)
            else if (response == "2")
            {
                usersJournal.ShowJournalPage();
            }
            // Saving all existing pages to the Journal file
            else if (response == "3")
            {
                usersJournal.SaveJournal();
            }
            // Display all entries saved in the Journal (txt file)
            else if (response == "4")
            {
                usersJournal.DisplayJournal();
            }
            // Filtering Journal entries
            else if (response == "5")
            {
                Console.WriteLine("Write a date to filter. Use the format: month/day/year");
                Console.WriteLine("Example: 1/31/2026");
                Console.WriteLine("Avoid using '01' Intead of '1'");
                string dateToFilter = Console.ReadLine();
                usersJournal.DisplayByDate(dateToFilter);
            }
            // Quiting the code
            else if (response == "6")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Try a number from 1 to 6!");
            }
        }
    }
}