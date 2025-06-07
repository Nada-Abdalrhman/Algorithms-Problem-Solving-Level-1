namespace Average_of_3_Marks;

class Program
{
    static void Main(string[] args)
    {
        // Problem Ten
        // Average of 3 Marks
        int mark1, mark2, mark3;
        ReadNumbers(out mark1, out mark2, out mark3);
        PrintResults(CalculateAverage(mark1, mark2, mark3));
        Console.ReadKey();
    }
    public static void ReadNumbers(out int num1, out int num2, out int num3)
    {
        Console.Write("Please enter your Mark 1 ? ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Please enter your Mark 2 ? ");
        num2 = int.Parse(Console.ReadLine());
        Console.Write("Please enter your Mark 3 ? ");
        num3 = int.Parse(Console.ReadLine());
    }
    public static int SumOf3Numbers(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }
    public static float CalculateAverage(int mark1, int mark2, int mark3)
    {
        return (float)SumOf3Numbers(mark1, mark2, mark3) / 3;
    }
    public static void PrintResults(float total)
    {
        Console.WriteLine($"The total average of Marks is: {total}");
    }
}

