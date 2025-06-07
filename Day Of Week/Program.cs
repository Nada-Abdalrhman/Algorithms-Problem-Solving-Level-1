
namespace Day_Of_Week;

class Program
{
    static void Main(string[] args)
    {
        // Problem Fourty Four
        // Day Of Week
        Console.WriteLine($"{GetDayOfWeek(ReadDayOfWeek())}");
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
    public static enDayofWeek ReadDayOfWeek()
    {
        return (enDayofWeek)ReadNumberInRange("Please enter a day number Sat = 1, Sun = 2, Mon = 3, Tue = 4, Wed = 5, Thu = 6, Fri = 7? ", 1, 7);
    }
    public static string GetDayOfWeek(enDayofWeek Day)
    {
        return Day.ToString();
    }
    
}
public enum enDayofWeek
{
    Saturday = 1,
    Sunday = 2,
    Monday = 3,
    Tuesday = 4,
    Wedenesday = 5,
    Thursday = 6,
    Friday = 7
}

