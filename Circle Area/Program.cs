namespace Circle_Area;

class Program
{
    static void Main(string[] args)
    {
        // Problem Eighteen
        // Circle Area
        PrintResult(CircleArea(ReadRadius()));
        Console.ReadKey();
    }
    public static float ReadRadius()
    {
        float Radius;
        Console.Write("Please enter circle Radius ? ");
        Radius = float.Parse(Console.ReadLine());
        return Radius;
    }
    public static float CircleArea(float Radius)
    {
        return (float)(Math.PI * Math.Pow(Radius, 2));
    }
    public static void PrintResult(float Area)
    {
        Console.WriteLine($"Circle Area = {Area}");
    }
}
