namespace Validate_Age_Between_18_and_45;

class Program
{
    static void Main(string[] args)
    {
        // Problem Twenty Four
        // Validate Age Between 18 and 45
        PrintResult(ReadAge());
        Console.ReadKey();
    }
    public static int ReadAge()
    {
        int Age;
        Console.Write("Please enter your Age ? ");
        Age = int.Parse(Console.ReadLine());
        return Age;
    }
    public static bool ValidateNumberInRange(int Number, int From, int To)
    {
        return (Number >= From && Number <= To);
    }
    public static void PrintResult(int Age)
    {
        if(ValidateNumberInRange(Age, 18, 45))
        {
            Console.WriteLine($"{Age} is a valid age");
        }
        else
        {
            Console.WriteLine($"{Age} is an invalid age");
        }
    }
}

