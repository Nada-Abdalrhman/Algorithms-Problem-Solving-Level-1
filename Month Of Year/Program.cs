using System;

namespace Month_Of_Year;

class Program
{
    static void Main(string[] args)
    {
        // Problem Fourty Five
        // Month Of Year
        Console.WriteLine($"{GetMonthOfYear(ReadMonthOfYear())}");

        Console.ReadKey();
    }
    public static int ReadNumberInRange(string Message, int From, int To)
    {
        int Number;
        do
        {
            Console.Write($"{Message} ");
            Number = int.Parse(Console.ReadLine());
        } while (!(Number >= From && Number <= To));
        return Number;
    }
    public static enMonthOfYear ReadMonthOfYear()
    {
        return (enMonthOfYear)ReadNumberInRange("Please enter a Month number Jan = 1, Feb = 2, Mar = 3, Apr = 4, May = 5, Jun = 6, Jul = 7, Aug = 8, Sep = 9, Oct = 10, Nov = 11, Dec = 12? ", 1, 12);
    }
    public static string GetMonthOfYear(enMonthOfYear Month)
    {
        return Month.ToString();
    }
}
public enum enMonthOfYear
{
    January = 1,
    February = 2,
    March = 3,
    April = 4,
    May = 5,
    June = 6,
    July = 7,
    August = 8,
    September = 9,
    October = 10,
    November = 11,
    December = 12
}

