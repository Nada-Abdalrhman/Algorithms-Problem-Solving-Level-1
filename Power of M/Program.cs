namespace Power_of_M;

class Program
{
    static void Main(string[] args)
    {

        // Problem Thirty Two
        // Power of M
        Console.WriteLine($"Result = {PowerOfM(ReadNumber(), ReadPower())}");

        Console.ReadKey();
    }
    public static int ReadNumber()
    {
        int N;
        Console.Write("Please enter a number ? ");
        N = int.Parse(Console.ReadLine());
        return N;
    }
    public static int ReadPower()
    {
        int M;
        Console.Write("Please enter the power ? ");
        M = int.Parse(Console.ReadLine());
        return M;
    }
    public static int PowerOfM(int Number, int Power)
    {
        if(Power == 0)
        {
            return 1;
        }
        int P = 1;
        for(int i = 1; i <= Power; i++)
        {
            P *= Number;
        }
        return P;
    }
}

