using System;

public class Predator
{
    public string Species { get; set; }
    public Claws Claws { get; set; }
    public Teeth Teeth { get; set; }
    public bool IsRunning { get; private set; }
    public bool IsSleeping { get; private set; }


    public Predator(string species)
    {
        Species = species;
        Claws = new Claws();
        Teeth = new Teeth();
    }

    public Predator(string species, int ClawsLength, string ClawsMaterial, int Sharpness, string Type)
    {
        Species = species;
        Claws = new Claws(ClawsLength,ClawsMaterial);
        Teeth = new Teeth(Sharpness,Type);
    }

    public void Roar()
    {
        Console.WriteLine($"{Species} is roaring!");
    }

    public void Run()
    {
        IsRunning = true;
        Console.WriteLine($"{Species} is running!");
    }

    public void Sleep()
    {
        IsSleeping = true;
        IsRunning = false;
        Console.WriteLine($"{Species} is sleeping.");
    }

    public void Hunt()
    {
        if (!IsSleeping)
        {
            Console.WriteLine($"{Species} is hunting for food.");
        }
        else
        {
            Console.WriteLine($"{Species} is sleeping and cannot hunt.");
        }
    }

    public void WakeUp()
    {
        IsSleeping = false;
    } 

    public void StopRunning()
    {
        IsRunning = false;
    }
}

public class Claws
{
    public int Length { get; set; }
    public string Material { get; set; }

    public Claws() { }
    public Claws(int length, string material)
    {
        Length = length;
        Material = material;
    }
}

public class Teeth
{
    public int Sharpness { get; set; }
    public string Type { get; set; }

    public Teeth() { }
    public Teeth(int sharpness, string type)
    {
        Sharpness = sharpness;
        Type = type;
    }
}

class Program
{
    static void Main()
    {
        Predator lion = new Predator("Lion");
        Predator Chupa = new Predator("Чупапімуняня", 20, "Tungsten", 50, "Spikes");
        
        if (lion.IsRunning)
        {
            Console.WriteLine("Lion біжить!");
        }
        lion.Roar();
        lion.Run();
        lion.Hunt();
        lion.Sleep();
        lion.Hunt();
        Chupa.Hunt();
    }
}
