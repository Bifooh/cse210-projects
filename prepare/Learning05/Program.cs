using System;

class Program
{
    static void Main(string[] args)
    {
        Animal a1 = new Frog();
        Animal a2 = new Cow();

        List<Animal> list = new List<Animal>();
        list.Add(a1);
        list.Add(a2);

        foreach (Animal a in list)
        {
            Console.WriteLine(a.GetSound());
        }
    }
}