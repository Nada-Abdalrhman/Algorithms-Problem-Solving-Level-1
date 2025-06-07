namespace Seconds_to_Days_Hours_Minutes_Seconds;

class Program
{
    static void Main(string[] args)
    {
        // Problem Fourty Three
        // Seconds to Days Hours Minutes Seconds
        int TotalSeconds = ReadPositiveNumber("Please enter total seconds? ");
        PrintTaskDurationDetails(SecondsToTaskDuration(TotalSeconds));
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
    public static stTaskDuration SecondsToTaskDuration(int TotalSeconds)
    {
        stTaskDuration TaskDuration = new stTaskDuration();
        const int SecondsPerDay = 24 * 60 * 60;
        const int SecondsPerHour = 60 * 60;
        const int SecondsPerMinute =  60;
        int Remainder = 0;
        TaskDuration.Days = TotalSeconds / SecondsPerDay;
        Remainder = TotalSeconds % SecondsPerDay;
        TaskDuration.Hours = Remainder / SecondsPerHour;
        Remainder %= SecondsPerHour;
        TaskDuration.Minutes = Remainder / SecondsPerMinute;
        Remainder %= SecondsPerMinute;
        TaskDuration.Seconds = Remainder;
        return TaskDuration;
    }
    public static void PrintTaskDurationDetails(stTaskDuration TaskDuration)
    {
        Console.WriteLine($"{TaskDuration.Days}:{TaskDuration.Hours}:{TaskDuration.Minutes}:{TaskDuration.Seconds}");
    }
}
public struct stTaskDuration
{
    public int Days;
    public int Hours;
    public int Minutes;
    public int Seconds;
}


