namespace Check_Odd_or_Even;

class Program
{
    static void Main(string[] args)
    {
        // Problem Three
        // Check Odd or Even
        printNumberType(CheckNumberType(ReadNumber()));

        Console.ReadKey();
    }
    public static int ReadNumber()
    {
        int num;
        Console.Write("Please enter a number? ");
        num = int.Parse(Console.ReadLine());
        return num;
    }
    public static enNumberType CheckNumberType(int num)
    {
        int result = num % 2;
        if (result == 0)
        {
            return enNumberType.Even;
        }
        else
        {
            return enNumberType.Odd;
        }
    }
    public static void printNumberType(enNumberType numberType)
    {
        if(numberType == enNumberType.Even)
        {
            Console.WriteLine("Number is even");
        }
        else
        {
            Console.WriteLine("Number is odd");
        }
    }
    
}
public enum enNumberType
{
    Odd = 1,
    Even = 2
}

