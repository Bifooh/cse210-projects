using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Motorcycle m = new Motorcycle("monkey", 2);
        Console.WriteLine(m.GetDescription());
    }
}