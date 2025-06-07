namespace Power_of_2__3__4;

class Program
{
    static void Main(string[] args)
    {
        // Problem Thirty One
        // Power of 2, 3, 4
        PowerOf2_3_4(ReadNumber());

        Console.ReadKey();
    }
    public static int ReadNumber()
    {
        int N;
        Console.Write("Please enter a number ? ");
        N = int.Parse(Console.ReadLine());
        return N;
    }
    public static void PowerOf2_3_4(int Number)
    {
        int a, b, c;
        a = Number * Number;
        b = Number * Number * Number;
        c = Number * Number * Number * Number;
        Console.WriteLine($"{a} {b} {c}");
    }

}

