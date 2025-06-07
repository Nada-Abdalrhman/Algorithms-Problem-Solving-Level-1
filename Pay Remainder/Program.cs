namespace Pay_Remainder;

class Program
{
    static void Main(string[] args)
    {
        // Problem Thirty Nine
        // Pay Remainder
        int TotalBill = ReadPositiveNumber("Please enter total bill? ");
        int TotalCashPaid = ReadPositiveNumber("Please enter total cash paid? ");
        Console.WriteLine($"Total Bill = {TotalBill}");
        Console.WriteLine($"Total Cash Paid = {TotalCashPaid}");
        Console.WriteLine($"**********************************");
        Console.WriteLine($"Remainder = {CalculateRemainder(TotalBill, TotalCashPaid)}");


        Console.ReadKey();
    }
    public static int ReadPositiveNumber(string Message)
    {
        int Number;
        do
        {
            Console.Write($"{Message} ");
            Number = int.Parse(Console.ReadLine());
        } while (Number < 0);
        return Number;
    }
    public static int CalculateRemainder(int TotalBill, int TotalCashPaid)
    {
        return TotalCashPaid - TotalBill;
    }
}

