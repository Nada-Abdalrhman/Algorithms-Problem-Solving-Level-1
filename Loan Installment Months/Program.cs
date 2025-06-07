namespace Loan_Installment_Months;

class Program
{
    static void Main(string[] args)
    {
        // Problem Fourty Seven
        // Loan Installment Months
        float LoanAmount = ReadPositiveNumber("Please enter loan amount? ");
        float MonthlyInstallment = ReadPositiveNumber("Please enter monthly installment? ");
        Console.WriteLine($"Total Months to pay = {TotalMonths(LoanAmount, MonthlyInstallment)} Months");
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
    public static float TotalMonths(float LoanAmount, float MonthlyInstallment)
    {
        return LoanAmount / MonthlyInstallment;
    }
}

