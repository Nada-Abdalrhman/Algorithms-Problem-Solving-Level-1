namespace Sum_of_3_Numbers;

class Program
{
    static void Main(string[] args)
    {
        // Problem Nine
        // Sum of 3 Numbers
        int num1, num2 , num3 ;
        ReadNumbers(out num1, out num2, out num3);
        PrintResults(SumOf3Numbers(num1, num2, num3));
        Console.ReadKey();
    }
    public static void ReadNumbers(out int num1, out int num2, out int num3)
    {
        Console.Write("Please enter your Number 1 ? ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Please enter your Number 2 ? ");
        num2 = int.Parse(Console.ReadLine());
        Console.Write("Please enter your Number 3 ? ");
        num3 = int.Parse(Console.ReadLine());
    }
    public static int SumOf3Numbers(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }
    public static void PrintResults(int total)
    {
        Console.WriteLine($"The total sum of numbers is: {total}");
    }
}