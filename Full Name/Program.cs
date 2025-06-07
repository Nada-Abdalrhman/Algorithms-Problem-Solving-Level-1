namespace Full_Name;

class Program
{
    static void Main(string[] args)
    {
        // Problem Six
        // Full Name
        PrintFullName(GetFullName(ReadInfo()));
        Console.ReadKey();
    }
    public static stInfo ReadInfo()
    {
        stInfo Info = new stInfo();
        Console.Write("Please Enter Your First Name? ");
        Info.FirstName = Console.ReadLine();
        Console.Write("Please Enter Your Last Name? ");
        Info.LastName = Console.ReadLine();
        return Info;
    }
    public static string GetFullName(stInfo Info)
    {
        string FullName = "";
        FullName = $"{Info.FirstName} {Info.LastName}";
        return FullName;
    }
    public static void PrintFullName(string FullName)
    {
        Console.WriteLine($"Your full name is: {FullName}");
    }
}
public struct stInfo
{
    public string FirstName;
    public string LastName;
}

