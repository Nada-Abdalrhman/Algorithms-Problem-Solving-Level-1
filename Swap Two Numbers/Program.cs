namespace Swap_Two_Numbers;

class Program
{
    static void Main(string[] args)
    {
        // Problem Fourteen
        // Swap Two Numbers
        int num1, num2;
        ReadNumbers(out num1, out num2);
        PrintNumbers(num1, num2);
        Swap(ref num1, ref num2);
        PrintNumbers(num1, num2);
        Console.ReadKey();
    }
    public static void ReadNumbers(out int num1, out int num2)
    {
        Console.Write("Please enter Number 1 ? ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Please enter Number 2 ? ");
        num2 = int.Parse(Console.ReadLine());
    }
    public static void PrintNumbers(int num1, int num2)
    {
        Console.WriteLine($"Number1 = {num1}\nNumber2 = {num2}");
    }
    public static void Swap(ref int num1, ref int num2)
    {
        int temp;
        temp = num1;
        num1 = num2;
        num2 = temp;
    }
}

