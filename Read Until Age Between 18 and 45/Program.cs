namespace Read_Until_Age_Between_18_and_45;

class Program
{
    static void Main(string[] args)
    {
        // Problem Twenty Five
        // Read Until Age Between 18 and 45
        PrintResult(ReadUntilAgeBetween(18, 45));
        Console.ReadKey();
    }
    public static int ReadAge()
    {
        int Age;
        Console.Write("Please enter your Age between 18 and 45 ? ");
        Age = int.Parse(Console.ReadLine());
        return Age;
    }
    public static bool ValidateNumberInRange(int Number, int From, int To)
    {
        return (Number >= From && Number <= To);
    }
    public static int ReadUntilAgeBetween(int From, int To)
    {
        int Age = 0;
        do
        {
            Age = ReadAge();
        } while (!ValidateNumberInRange(Age, From, To));
        return Age;
    }
    public static void PrintResult(int Age)
    {
        Console.WriteLine($"Your Age is: {Age}");
    }
}

