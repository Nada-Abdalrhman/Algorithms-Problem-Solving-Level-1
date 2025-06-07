namespace Factorial_of_N;

class Program
{
    static void Main(string[] args)
    {
        // Problem Thirty
        // Factorial of N
        Console.WriteLine(Factorial(ReadPositiveNumber("Please enter a positive number?")));
        Console.WriteLine(Factorial2(ReadPositiveNumber("Please enter a positive number?")));

        Console.ReadKey();
    }
    public static int ReadPositiveNumber(string Message)
    {
        int Number;
        do
        {
            Console.Write($"{Message} ");
            Number = int.Parse(Console.ReadLine());
        } while (Number < 0);
        return Number;
    }
    public static int Factorial(int N)
    {
        int F = 1;
        for(int i = N; i >= 1; i--)
        {
            F *= i;
        }
        return F;
    }
    public static int Factorial2(int N)
    {
        if (N == 1)
            return 1;
        return N * Factorial(N - 1);
    }
}

