namespace Prime_Number;

class Program
{
    static void Main(string[] args)
    {
        // Problem Thirty Eight
        // Prime Number
        PrintNumberType(ReadPositiveNumber("Please enter a positive number ? "));

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
    public static enPrimeNotPrime CheckPrime(int Number)
    {
        int m = Number / 2;
        for(int i = 2; i <= m; i++)
        {
            if (Number % i == 0)
                return enPrimeNotPrime.NotPrime;
        }
        return enPrimeNotPrime.Prime;
    }
    public static void PrintNumberType(int Number)
    {
        switch (CheckPrime(Number))
        {
            case enPrimeNotPrime.Prime:
                Console.WriteLine("The number is prime.");
                break;
            case enPrimeNotPrime.NotPrime:
                Console.WriteLine("The number is not prime.");
                break;
        }
    }
}
public enum enPrimeNotPrime
{
    Prime = 1,
    NotPrime = 2
}

