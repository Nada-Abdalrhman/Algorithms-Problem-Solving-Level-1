namespace Rectangle_Area_By_Diagonal_and_Side;

class Program
{
    static void Main(string[] args)
    {
        // Problem Sixteen
        // Rectangle Area By Diagonal and Side
        float Side, Diagonal;
        ReadNumbers(out Side, out Diagonal);
        PrintResult(RectangleAreaBySideAndDiagonal(Side, Diagonal));
        Console.ReadKey();
    }
    public static void ReadNumbers(out float Side, out float Diagonal)
    {
        Console.Write("Please enter rectangle Side ? ");
        Side = float.Parse(Console.ReadLine());
        Console.Write("Please enter rectangle Diagonal ? ");
        Diagonal = float.Parse(Console.ReadLine());
    }
    public static double RectangleAreaBySideAndDiagonal(float Side, float Diagonal)
    {
        return Side * (Math.Sqrt(Math.Pow(Diagonal, 2) - Math.Pow(Side, 2)));
    }
    public static void PrintResult(double Area)
    {
        Console.WriteLine($"Rectangle Area = {Area}");
    }
}

