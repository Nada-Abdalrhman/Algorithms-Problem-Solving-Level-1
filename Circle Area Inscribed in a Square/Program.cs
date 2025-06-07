namespace Circle_Area_Inscribed_in_a_Square;

class Program
{
    static void Main(string[] args)
    {
        // Problem Twenty
        // Circle Area Inscribed in a Square
        PrintResult(CircleAreaInscribedInSquare(ReadSquareSide()));
        Console.ReadKey();
    }
    public static float ReadSquareSide()
    {
        float Side;
        Console.Write("Please enter square Side ? ");
        Side = float.Parse(Console.ReadLine());
        return Side;
    }
    public static float CircleAreaInscribedInSquare(float Side)
    {
        return (float)((Math.PI * Math.Pow(Side, 2)) / 4);
    }
    public static void PrintResult(float Area)
    {
        Console.WriteLine($"Circle Area = {Area}");
    }
}

