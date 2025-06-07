using System.Diagnostics.Metrics;

namespace Print_Numbers_from_1_to_N;

class Program
{
    static void Main(string[] args)
    {
        // Problem Twenty Six
        // Print Numbers from 1 to N
        int N = ReadNumber();
        PrintRangeFrom1toNUsingWhile(N);
        PrintRangeFrom1toNUsingDoWhile(N);
        PrintRangeFrom1toNUsingFor(N);

        Console.ReadKey();
    }
    public static int ReadNumber()
    {
        int N;
        Console.Write("Please enter a number ? ");
        N = int.Parse(Console.ReadLine());
        return N;
    }
    public static void PrintRangeFrom1toNUsingWhile(int N)
    {
        int Counter = 1;
        Console.WriteLine("Range printed using While statment: ");
        while (Counter <= N)
        {
            Console.WriteLine($"{Counter}");
            Counter++;
        }
    }
    public static void PrintRangeFrom1toNUsingDoWhile(int N)
    {
        int Counter = 1;
        Console.WriteLine("Range printed using Do While statment: ");
        do
        {
            Console.WriteLine($"{Counter}");
            Counter++;
        } while (Counter <= N);
    }
    public static void PrintRangeFrom1toNUsingFor(int N)
    {
        Console.WriteLine("Range printed using For Loop statment: ");
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine($"{i}");
        }
    }
}

