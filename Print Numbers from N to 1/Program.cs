namespace Print_Numbers_from_N_to_1;

class Program
{
    static void Main(string[] args)
    {
        // Problem Twenty Seven
        // Print Numbers from N to 1
        int N = ReadNumber();
        PrintRangeFromNto1UsingWhile(N);
        PrintRangeFromNto1UsingDoWhile(N);
        PrintRangeFromNto1UsingFor(N);

        Console.ReadKey();
    }
    public static int ReadNumber()
    {
        int N;
        Console.Write("Please enter a number ? ");
        N = int.Parse(Console.ReadLine());
        return N;
    }
    public static void PrintRangeFromNto1UsingWhile(int N)
    {
        int Counter = N;
        Console.WriteLine("Range printed using While statment: ");
        while (Counter >= 1)
        {
            Console.WriteLine($"{Counter}");
            Counter--;
        }
    }
    public static void PrintRangeFromNto1UsingDoWhile(int N)
    {
        int Counter = N;
        Console.WriteLine("Range printed using Do While statment: ");
        do
        {
            Console.WriteLine($"{Counter}");
            Counter--;
        } while (Counter >= 1);
    }
    public static void PrintRangeFromNto1UsingFor(int N)
    {
        Console.WriteLine("Range printed using For Loop statment: ");
        for (int i = N; i >= 1; i--)
        {
            Console.WriteLine($"{i}");
        }
    }
}

