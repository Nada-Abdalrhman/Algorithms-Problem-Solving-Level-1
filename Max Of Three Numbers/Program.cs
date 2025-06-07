namespace Max_Of_Three_Numbers;

class Program
{
    static void Main(string[] args)
    {
        // Problem Thirteen
        // Max of Three Numbers
        int num1, num2, num3;
        ReadNumbers(out num1, out num2, out num3);
        PrintResults(MaxOf3Numbers(num1, num2, num3));
        Console.ReadKey();
    }
    public static void ReadNumbers(out int num1, out int num2, out int num3)
    {
        Console.Write("Please enter Number 1 ? ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Please enter Number 2 ? ");
        num2 = int.Parse(Console.ReadLine());
        Console.Write("Please enter Number 3 ? ");
        num3 = int.Parse(Console.ReadLine());
    }
    public static int MaxOf3Numbers(int num1, int num2, int num3)
    {
        if (num1 > num2)
            if (num1 > num3)
                return num1;
            else
                return num3;
        else
            if (num2 > num3)
                return num2;
            else
                return num3;
    }
    public static void PrintResults(int Max)
    {
        Console.WriteLine($"The Maximum Number is: {Max}");
    }
}

