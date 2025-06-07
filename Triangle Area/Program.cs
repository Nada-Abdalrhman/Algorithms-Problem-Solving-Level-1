namespace Triangle_Area;

class Program
{
    static void Main(string[] args)
    {
        // Problem Seventeen
        // Triangle Area
        float Base, Height;
        ReadNumbers(out Base, out Height);
        PrintResult(TriangleArea(Base, Height));
        Console.ReadKey();
    }
    public static void ReadNumbers(out float Base, out float Height)
    {
        Console.Write("Please enter triangle Base ? ");
        Base = float.Parse(Console.ReadLine());
        Console.Write("Please enter triangle Height ? ");
        Height = float.Parse(Console.ReadLine());
    }
    public static float TriangleArea(float Base, float Height)
    {
        return (Base / 2) * Height;
    }
    public static void PrintResult(float Area)
    {
        Console.WriteLine($"Triangle Area = {Area}");
    }
}