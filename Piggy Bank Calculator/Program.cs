namespace Piggy_Bank_Calculator;

class Program
{
    static void Main(string[] args)
    {
        // Problem Thirty Five
        // Piggy Bank Calculator
        int TotalPennies = CalculateTotalPennies(ReadPiggyBankContent());
        Console.WriteLine($"Total Pennies = {TotalPennies}");
        Console.WriteLine($"Total Dollars = {(float)TotalPennies / 100}");
        Console.ReadKey();
    }
    public static stPiggyBankContent ReadPiggyBankContent()
    {
        stPiggyBankContent PiggyBankContent = new stPiggyBankContent();
        Console.Write($"Please enter a total pennies ? ");
        PiggyBankContent.Pennies = int.Parse(Console.ReadLine());
        Console.Write($"Please enter a total nickels ? ");
        PiggyBankContent.Nickels = int.Parse(Console.ReadLine());
        Console.Write($"Please enter a total dimes ? ");
        PiggyBankContent.Dimes = int.Parse(Console.ReadLine());
        Console.Write($"Please enter a total quarters ? ");
        PiggyBankContent.Quarters = int.Parse(Console.ReadLine());
        Console.Write($"Please enter a total dollars ? ");
        PiggyBankContent.Dollars = int.Parse(Console.ReadLine());
        return PiggyBankContent;
    }
    public static int CalculateTotalPennies(stPiggyBankContent PiggyBankContent)
    {
        int total = PiggyBankContent.Pennies + (PiggyBankContent.Nickels * 5) + (PiggyBankContent.Dimes * 10) + (PiggyBankContent.Quarters * 25) + (PiggyBankContent.Dollars * 100);
        return total;
    }
}
public struct stPiggyBankContent
{
    public int Pennies;
    public int Nickels;
    public int Dimes;
    public int Quarters;
    public int Dollars;
}