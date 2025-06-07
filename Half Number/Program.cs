namespace Half_Number;

class Program
{
    static void Main(string[] args)
    {
        // Problem Seven
        // Half Number
        PrintResults(ReadNumber());
        Console.ReadKey();
    }
    public static int ReadNumber()
    {
        int num;
        Console.Write("Please enter a number? ");
        num = int.Parse(Console.ReadLine());
        return num;
    }
    public static float CalculateHalfNumber(int num)
    {
        return (float)num / 2;
    }
    public static void PrintResults(int num)
    {
        string Result = $"Half of {num} is {CalculateHalfNumber(num)}";
        Console.WriteLine(Result);
    }
}

