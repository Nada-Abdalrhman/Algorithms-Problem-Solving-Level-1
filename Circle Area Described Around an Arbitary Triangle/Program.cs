namespace Circle_Area_Described_Around_an_Arbitary_Triangle;

class Program
{
    static void Main(string[] args)
    {
        // Problem Twenty Three
        // Circle Area Described Around an Arbitary Triangle
        float a, b, c;
        ReadNumbers(out a, out b, out c);
        PrintResult(CircleDescribedAroundArbitaryTriangle(a, b, c));
        Console.ReadKey();
    }
    public static void ReadNumbers(out float a, out float b, out float c)
    {
        Console.Write("Please enter triangle Side 1 ? ");
        a = float.Parse(Console.ReadLine());
        Console.Write("Please enter triangle Side 2 ? ");
        b = float.Parse(Console.ReadLine());
        Console.Write("Please enter triangle Side 3 ? ");
        c = float.Parse(Console.ReadLine());
    }
    public static float CircleDescribedAroundArbitaryTriangle(float a, float b, float c)
    {
        float p = (a + b + c) / 2;
        return (float)(Math.PI * Math.Pow(a * b * c / (4 * (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c))), 2));
    }
    public static void PrintResult(float Area)
    {
        Console.WriteLine($"Circle Area = {Area}");
    }
}

