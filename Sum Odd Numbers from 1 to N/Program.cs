namespace Sum_Odd_Numbers_from_1_to_N;

class Program
{
    static void Main(string[] args)
    {
        // Problem Twenty Eight
        // Sum Odd Numbers from 1 to N
        int N = ReadNumber();
        Console.WriteLine(SumOddNumbersFrom1toNUsingWhile(N));
        Console.WriteLine(SumOddNumbersFrom1toNUsingDoWhile(N));
        Console.WriteLine(SumOddNumbersFrom1toNUsingFor(N));

        Console.ReadKey();
    }
    public static int ReadNumber()
    {
        int N;
        Console.Write("Please enter a number ? ");
        N = int.Parse(Console.ReadLine());
        return N;
    }
    public static enNumberType CheckNumberType(int num)
    {
        int result = num % 2;
        if (result == 0)
        {
            return enNumberType.Even;
        }
        else
        {
            return enNumberType.Odd;
        }
    }
    public static int SumOddNumbersFrom1toNUsingWhile(int N)
    {
        int sum = 0;
        int Counter = 1;
        Console.WriteLine("Sum Odd Numbers using While statment: ");
        while (Counter <= N)
        {
            if (CheckNumberType(Counter) == enNumberType.Odd)
            {
                sum += Counter;
            }
            Counter++;
        }
        return sum;
    }
    public static int SumOddNumbersFrom1toNUsingDoWhile(int N)
    {
        int sum = 0;
        int Counter = 1;
        Console.WriteLine("Sum Odd Numbers using Do While statment: ");
        do
        {
            if (CheckNumberType(Counter) == enNumberType.Odd)
            {
                sum += Counter;
            }
            Counter++;
        } while (Counter <= N);
        return sum;
    }
    public static int SumOddNumbersFrom1toNUsingFor(int N)
    {
        int sum = 0;
        Console.WriteLine("Sum Odd Numbers using For Loop statment: ");
        for (int i = 1; i <= N; i++)
        {
            if(CheckNumberType(i) == enNumberType.Odd)
            {
                sum += i;
            }
        }
        return sum;
    }
}
public enum enNumberType
{
    Odd = 1,
    Even = 2
}


