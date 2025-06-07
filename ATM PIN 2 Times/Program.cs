namespace ATM_PIN_3_Times;

class Program
{
    static void Main(string[] args)
    {
        // Problem Fifty
        // ATM PIN 3 Times
        if (Login())
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your account balance is 7500");
            Console.BackgroundColor = ConsoleColor.Black;
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"Your card blocked call the bank for help.");
            Console.BackgroundColor = ConsoleColor.Black;
        }
        Console.ReadKey();
    }
    public static string ReadPinCode()
    {
        string PinCode;
        Console.Write($"Please enter PIN code ");
        PinCode = Console.ReadLine();
        return PinCode;
    }
    public static bool Login()
    {
        string PinCode;
        int Counter = 3;
        do
        {
            PinCode = ReadPinCode();
            if (PinCode == "1234")
            {
                return true;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Wrong PIN, you have {Counter--} more tries");
                Console.BackgroundColor = ConsoleColor.Black;
            }

        } while (PinCode != "1234" && Counter >= 1);
        return false;
    }
}