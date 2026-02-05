using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction myFract = new Fraction();

        for (int i = 1; i <= 20; i++)
        {
            Random randomObject = new Random();
            int _randomTop = randomObject.Next(200) + 1;
            int _randomBottom = randomObject.Next(50) + 1;

            myFract.SetTop(_randomTop);
            myFract.SetBottom(_randomBottom);

            string stg = myFract.GetFractionString();
            double dbl = myFract.GetDecimalValue();

            Console.WriteLine($"Fraction {i}: string: {stg} Number: {dbl:F2}");
        }
    }
}