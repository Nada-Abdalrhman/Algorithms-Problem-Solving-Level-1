namespace Task_Duration_In_Seconds;

class Program
{
    static void Main(string[] args)
    {
        // Problem Fourty Two
        // Task Duration In Seconds
        Console.WriteLine($"Task Duration In Seconds: {TaskDurationInSeconds(ReadTaskDuration()).ToString("N0")} Seconds");

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
    public static stTaskDuration ReadTaskDuration()
    {
        stTaskDuration TaskDuration = new stTaskDuration();
        TaskDuration.Days = ReadPositiveNumber("Please enter a number of days? ");
        TaskDuration.Hours = ReadPositiveNumber("Please enter a number of hours? ");
        TaskDuration.Minutes = ReadPositiveNumber("Please enter a number of minutes? ");
        TaskDuration.Seconds = ReadPositiveNumber("Please enter a number of seconds? ");
        return TaskDuration;
    }
    public static int TaskDurationInSeconds(stTaskDuration TaskDuration)
    {
        int DaysToSeconds = TaskDuration.Days * 24 * 60 * 60;
        int HoursToSeconds = TaskDuration.Hours * 60 * 60;
        int MinutesToSeconds = TaskDuration.Minutes * 60;
        return DaysToSeconds + HoursToSeconds + MinutesToSeconds + TaskDuration.Seconds;
    }
}
public struct stTaskDuration
{
    public int Days;
    public int Hours;
    public int Minutes;
    public int Seconds;
}

