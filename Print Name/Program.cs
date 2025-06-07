namespace Print_Name;

class Program
{
    static void Main(string[] args)
    {
        // Problem One
        // Print Name
        PrintName("Nada");

        Console.ReadKey();
    }
    public static void PrintName(string name)
    {
        Console.WriteLine($"Your Name is: {name}");
    }
}

