namespace Weeks_and_Days;

class Program
{
    static void Main(string[] args)
    {
        // Problem Fourty One
        // Weeks and Days
        float NumberOfHours = ReadPositiveNumber("Please enter number of hours? ");
        float NumberOfDays = HoursToDays(NumberOfHours);
        float NumberOfWeeks = DaysToWeeks(NumberOfDays);
        Console.WriteLine($"Total Hours = {NumberOfHours}");
        Console.WriteLine($"Total Days = {NumberOfDays}");
        Console.WriteLine($"Total Weeks = {HoursToWeeks(NumberOfHours)}");

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
    public static float HoursToDays(float NumberOfHours)
    {
        return NumberOfHours / 24;
    }
    public static float HoursToWeeks(float NumberOfHours)
    {
        return NumberOfHours / 24 / 7;
    }
    public static float DaysToWeeks(float NumberOfDays)
    {
        return NumberOfDays / 7;
    }
}

