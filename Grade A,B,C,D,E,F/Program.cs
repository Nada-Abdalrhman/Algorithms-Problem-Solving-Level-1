namespace Grade_A_B_C_D_E_F;

class Program
{
    static void Main(string[] args)
    {
        // Problem Thirty Three
        // Grade A,B,C,D,E,F
        Console.WriteLine($"Result = {GetGradeLetter(ReadNumberInRange(0, 100))}");
        Console.ReadKey();
    }
    public static int ReadNumberInRange(int From, int To)
    {
        int N;
        do
        {
            Console.Write($"Please enter a valid number from {From} to {To} ? ");
            N = int.Parse(Console.ReadLine());
        } while (!(N >= From && N <= To));
        return N;
    }
    public static char GetGradeLetter(int Grade)
    {
        if (Grade >= 90 && Grade <= 100)
            return 'A';
        else if (Grade >= 80 && Grade <= 89)
            return 'B';
        else if (Grade >= 70 && Grade <= 79)
            return 'C';
        else if (Grade >= 60 && Grade <= 69)
            return 'D';
        else if (Grade >= 50 && Grade <= 59)
            return 'E';
        else
            return 'F';
    }
}

