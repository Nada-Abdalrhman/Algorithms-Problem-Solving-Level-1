namespace Read_Name_and_Print_It;

class Program
{
    static void Main(string[] args)
    {
        // Problem Two
        // Read Name and Print It
        PrintName(ReadName());

        Console.ReadKey();
    }
    public static void PrintName(string name)
    {
        Console.WriteLine($"Your Name is: {name}");
    }
    public static string ReadName()
    {
        Console.Write($"Please enter your name? ");
        string name = Console.ReadLine();
        return name;
    }
}

