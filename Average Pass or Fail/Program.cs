namespace Average_Pass_or_Fail;

class Program
{
    static void Main(string[] args)
    {
        // Problem Eleven
        // Average Pass of Fail
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
    public static enPassFail CheckAverage(float Average)
    {
        if (Average >= 50)
        {
            return enPassFail.Pass;
        }
        else
        {
            return enPassFail.Fail;
        }
    }
    public static void PrintResults(float Average)
    {
        Console.WriteLine($"Your Average is: {Average}");
        if(CheckAverage(Average) == enPassFail.Pass)
        {
            Console.WriteLine("You Passed");
        }
        else
        {
            Console.WriteLine("You Failed");
        }
    }
}
public enum enPassFail
{
    Pass = 1,
    Fail = 2
}

