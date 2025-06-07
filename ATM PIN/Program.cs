namespace ATM_PIN;

class Program
{
    static void Main(string[] args)
    {
        // Problem Fourty Nine
        // ATM PIN
        if (Login())
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your account balance is 7500");
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
        do
        {
            PinCode = ReadPinCode();
            if(PinCode == "1234")
            {
                return true;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong PIN");
                Console.BackgroundColor = ConsoleColor.Black;
            }

        } while (true);
    }
}

