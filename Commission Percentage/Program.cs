namespace Commission_Percentage;

class Program
{
    static void Main(string[] args)
    {
        // Problem Thirty Four
        // Commission Percentage
        float TotalSales = ReadTotalSales();
        Console.WriteLine($"Commission Percentage = {GetCommissionPercentage(TotalSales)}");
        Console.WriteLine($"Total Commission = {CalculateTotalCommission(TotalSales)}");

        Console.ReadKey();
    }
    public static float ReadTotalSales()
    {
        float N;
        Console.Write("Please enter a total sales ? ");
        N = float.Parse(Console.ReadLine());
        return N;
    }
    public static float GetCommissionPercentage(float TotalSales)
    {
        if (TotalSales >= 1000000)
            return (float)0.01;
        else if (TotalSales >= 500000)
            return (float)0.02;
        else if (TotalSales >= 100000)
            return (float)0.03;
        else if (TotalSales >= 50000)
            return (float)0.05;
        else
            return 0;

    }
    public static float CalculateTotalCommission(float TotalSales)
    {
        return GetCommissionPercentage(TotalSales) * TotalSales;
    }
}

