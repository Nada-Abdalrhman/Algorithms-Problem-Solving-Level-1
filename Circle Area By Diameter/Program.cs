namespace Circle_Area_By_Diameter;

class Program
{
    static void Main(string[] args)
    {
        // Problem Nineteen
        // Circle Area By Diameter
        PrintResult(CircleArea(ReadDiameter()));
        Console.ReadKey();
    }
    public static float ReadDiameter()
    {
        float Diameter;
        Console.Write("Please enter circle Diameter ? ");
        Diameter = float.Parse(Console.ReadLine());
        return Diameter;
    }
    public static float CircleArea(float Diameter)
    {
        return (float)((Math.PI * Math.Pow(Diameter, 2)) / 4);
    }
    public static void PrintResult(float Area)
    {
        Console.WriteLine($"Circle Area = {Area}");
    }
}

