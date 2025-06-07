namespace Circle_Area_Inscribed_in_an_Isosceles_Triangle;

class Program
{
    static void Main(string[] args)
    {
        // Problem Twenty Two
        // Circle Area Inscribed in an Isosceles Triangle
        float Base, Side;
        ReadNumbers(out Base, out Side);
        PrintResult(CircleAreaInscribedInIsoscelesTriangle(Base, Side));
        Console.ReadKey();
    }
    public static void ReadNumbers(out float Base, out float Side)
    {
        Console.Write("Please enter triangle Base ? ");
        Base = float.Parse(Console.ReadLine());
        Console.Write("Please enter triangle Side ? ");
        Side = float.Parse(Console.ReadLine());
    }
    public static float CircleAreaInscribedInIsoscelesTriangle(float Base, float Side)
    {
        return (float)(Math.PI * (Math.Pow(Base, 2) / 4) * ((2 * Side - Base) / (2 * Side + Base)));
    }
    public static void PrintResult(float Area)
    {
        Console.WriteLine($"Circle Area = {Area}");
    }
}

