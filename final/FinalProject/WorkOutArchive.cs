using System;
using System.Collections.Generic;
using System.IO;

public class WorkOutArchive
{
    private List<Cardio> _cardioExs = new List<Cardio>();
    private List<Strength> _StrengthExs = new List<Strength>();

    // Establishing the local CSV file name
    private string _historyFileName = "workout_history.csv";

    public void AddExercise(Exercise exercise)
    {
        // The 'true' parameter in StreamWriter tells it to append to the file rather than overwrite it
        using (StreamWriter outputFile = new StreamWriter(_historyFileName, true))
        {
            string date = DateTime.Now.ToShortDateString();
            string type = exercise is Cardio ? "Cardio" : "Strength"; // change sintax to a regular if statement


            // Saves a single line per exercise formatted for CSV
            outputFile.WriteLine($"{date},{exercise.GetName()},{type},{exercise.GetCaloriesBurnt()}");
        }
    }

    public void DisplayHistory()
    {
        if (!File.Exists(_historyFileName))
        {
            Console.WriteLine("No workout history found yet. Go do some exercises!");
            return;
        }

        Console.WriteLine("\n=== Your Workout History ===");
        string[] lines = File.ReadAllLines(_historyFileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            if (parts.Length >= 4)
            {
                Console.WriteLine($"Date: {parts[0]} | Exercise: {parts[1]} | Type: {parts[2]} | Calories: {parts[3]}");
            }
        }
        Console.WriteLine("============================\n");
    }

    public string GetProgressionAdvise()
    {
        return "Keep pushing forward!";
    }
}