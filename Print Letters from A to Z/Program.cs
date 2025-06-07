namespace Print_Letters_from_A_to_Z;

class Program
{
    static void Main(string[] args)
    {
        // Problem Fourty Six
        // Print Letters from A to Z
        PrintLettersAtoZ();
        Console.ReadKey();
    }
    public static void PrintLettersAtoZ()
    {
        for(int i = 65; i <= 90; i++)
        {
            Console.WriteLine((char)i);
        }
    }
}

