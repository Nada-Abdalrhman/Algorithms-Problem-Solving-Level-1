namespace Simple_Calculator;

class Program
{
    static void Main(string[] args)
    {
        // Problem Thirty Six
        // Simple Calculator
        float num1 = ReadNumber("Please enter the first number? ");
        float num2 = ReadNumber("Please enter the second number? ");
        enOperationType OpType = ReadOpType();
        Console.WriteLine($"Result = {Calculate(num1, num2, OpType)}");

        Console.ReadKey();
    }
    public static float ReadNumber(string Message)
    {
        float N;
        Console.Write($"{Message} ");
        N = float.Parse(Console.ReadLine());
        return N;
    }
    public static enOperationType ReadOpType()
    {
        char OT = '+';
        Console.Write("Please enter operation type (+, -, *, /)? ");
        OT = char.Parse(Console.ReadLine());
        return (enOperationType)OT;
    }
    public static float Calculate(float Number1, float Number2, enOperationType OpType)
    {
        switch (OpType)
        {
            case enOperationType.Add:
                return Number1 + Number2;
            case enOperationType.Subtract:
                return Number1 - Number2;
            case enOperationType.Multiply:
                return Number1 * Number2;
            case enOperationType.Divide:
                return Number1 / Number2;
            default:
                return Number1 + Number2;
        }
    }
}
public enum enOperationType
{
    Add = '+',
    Subtract = '-',
    Multiply = '*',
    Divide = '/'
}

