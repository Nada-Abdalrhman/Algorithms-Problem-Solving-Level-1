namespace Mark_Pass_Fail;

class Program
{
    static void Main(string[] args)
    {
        // Problem Eight
        // Mark Pass Fail
        PrintResults(ReadMark());
        Console.ReadKey();
    }
    public static int ReadMark()
    {
        int num;
        Console.Write("Please enter your mark? ");
        num = int.Parse(Console.ReadLine());
        return num;
    }
    public static enPassFail CheckMark(int mark)
    {
        if(mark >= 50)
        {
            return enPassFail.Pass;
        }
        else
        {
            return enPassFail.Fail;
        }
    }
    public static void PrintResults(int mark)
    {
        if(CheckMark(mark) == enPassFail.Pass)
        {
            Console.WriteLine($"You Passed");
        }
        else
        {
            Console.WriteLine($"You Failed");
        }
    }
}
public enum enPassFail
{
    Pass = 1,
    Fail = 2
}

