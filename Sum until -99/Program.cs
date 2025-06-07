namespace Sum_until__99;

class Program
{
    static void Main(string[] args)
    {
        // Problem Thirty Seven
        // Sum until -99
        Console.WriteLine($"Result = {SumNumbers()}");

        Console.ReadKey();
    }
    public static int ReadNumber(string Message)
    {
        int N;
        Console.Write($"{Message} ");
        N = int.Parse(Console.ReadLine());
        return N;
    }
    public static int SumNumbers()
    {
        int sum = 0;
        int num = 0;
        int counter = 1;
        do
        {
            num = ReadNumber($"Please enter a number {counter++} ?");
            if (num == -99)
                break;
            sum += num;
        } while (true);
        return sum;
    }
}

