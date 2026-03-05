using System;
using System.Data;

// I created a Book.cs with multiple Scripture (with reference and verse(s)).
// Users will have a different domain Scripture everytime they start the program.

// ONE BIG PROBLEM though is that the Console.Clear(); method doesn't work at all in my end, so I did a Try/Catch to just print lines for when I get the IOException error.

class Program
{
    public static Book _b;

    static void Main(string[] args)
    {
        _b = new Book();
        Scripture _pickedScripture = _b.GetScripture();
        

        Console.WriteLine("Hello Develop04 World!");

        while (true)
        {
            _pickedScripture.PrintScripture();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            Console.WriteLine();
            string input = Console.ReadLine();

            if (_pickedScripture.CheckScriptureIsHidden() == false)
            {
                if (input == "")
                {
                    _pickedScripture.HideWordsRandomly();
                }
                else if (input == "quit" || input == "q")
                {
                    break;
                }
                
            }
            else if (_pickedScripture.CheckScriptureIsHidden() == true)
            {
                break;
            }

            try 
            { 
                Console.Clear(); 
            } 
            catch (IOException) 
            { 
                Console.WriteLine("\n\n\n"); 
            }
        }
    }
}