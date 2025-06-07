namespace Rectangle_Area;

class Program
{
    static void Main(string[] args)
    {
        // Problem Fifteen
        // Rectangle Area
        float length, width;
        ReadNumbers(out length, out width);
        PrintResult(CalculateRectangleArea(length, width));
        Console.ReadKey();
    }
    public static void ReadNumbers(out float length, out float width)
    {
        Console.Write("Please enter rectangle width ? ");
        width = float.Parse(Console.ReadLine());
        Console.Write("Please enter rectangle length ? ");
        length = float.Parse(Console.ReadLine());
    }
    public static float CalculateRectangleArea(float length, float width)
    {
        return length * width;
    }
    public static void PrintResult(float Area)
    {
        Console.WriteLine($"Rectangle Area = {Area}");
    }
}

