namespace Circle_Area_Along_the_Circumference;

class Program
{
    static void Main(string[] args)
    {
        // Problem Twenty One
        // Circle Area Along the Circumference
        PrintResult(CircleAreaAlongTheCircumference(ReadSquareSide()));
        Console.ReadKey();
    }
    public static float ReadSquareSide()
    {
        float Circumference;
        Console.Write("Please enter circle Circumference ? ");
        Circumference = float.Parse(Console.ReadLine());
        return Circumference;
    }
    public static float CircleAreaAlongTheCircumference(float Circumference)
    {
        return (float)(Math.Pow(Circumference, 2) / (4 * Math.PI));
    }
    public static void PrintResult(float Area)
    {
        Console.WriteLine($"Circle Area = {Area}");
    }
}

