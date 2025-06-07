namespace Hire_a_driver_Case_1;

class Program
{
    static void Main(string[] args)
    {
        // Problem Four
        // Hire a driver case 1
        PrintResult(ReadInfo());

        Console.ReadKey();
    }
    public static stInfo ReadInfo()
    {
        stInfo Info = new stInfo();
        Console.Write("Please Enter Your Age? ");
        Info.Age = int.Parse(Console.ReadLine());
        Console.Write("Do you have a driver license? ");
        Info.HasDrivingLicense = bool.Parse(Console.ReadLine());
        return Info;
    }
    public static bool IsAccepted(stInfo Info)
    {
        return (Info.Age > 21 && Info.HasDrivingLicense);
    }
    public static void PrintResult(stInfo Info)
    {
        if (IsAccepted(Info))
        {
            Console.WriteLine($"Hired");
        }
        else
        {
            Console.WriteLine($"Rejected");
        }
    }
}
public struct stInfo
{
    public int Age;
    public bool HasDrivingLicense;
}
