namespace Monthly_Loan_Installment;

class Program
{
    static void Main(string[] args)
    {
        // Problem Fourty Eight
        // Monthly Loan Installment
        float LoanAmount = ReadPositiveNumber("Please enter loan amount? ");
        float Months = ReadPositiveNumber("How many months? ");
        Console.WriteLine($"Monthly Instatllment = {MonthlyInstatllment(LoanAmount, Months)} Per Month");
        Console.ReadKey();
    }
    public static float ReadPositiveNumber(string Message)
    {
        float Number;
        do
        {
            Console.Write($"{Message} ");
            Number = float.Parse(Console.ReadLine());
        } while (Number < 0);
        return Number;
    }
    public static float MonthlyInstatllment(float LoanAmount, float Months)
    {
        return LoanAmount / Months;
    }
}

