namespace Service_Fee_and_Sales_Tax;

class Program
{
    static void Main(string[] args)
    {
        // Problem Fourty
        // Service Fee and Sales Tax
        int TotalBill = ReadPositiveNumber("Please enter total bill? ");
        Console.WriteLine($"Total Bill = {TotalBill}");
        Console.WriteLine($"Total Bill After Service And Tax = {TotalBillAfterServiceAndTax(TotalBill)}");

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
    public static float TotalBillAfterServiceAndTax(int TotalBill)
    {
        return (float)(TotalBill * 1.1 * 1.16);
    }
}

