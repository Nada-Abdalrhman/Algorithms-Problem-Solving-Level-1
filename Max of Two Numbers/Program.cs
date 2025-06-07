using System;

namespace Max_of_Two_Numbers;

class Program
{
    static void Main(string[] args)
    {
        // Problem Twelve
        // Max of Two Numbers
        int num1, num2;
        ReadNumbers(out num1, out num2);
        PrintResults(MaxOf2Numbers(num1, num2));


        Console.ReadKey();
    }
    public static void ReadNumbers(out int num1, out int num2)
    {
        Console.Write("Please enter Number 1 ? ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Please enter Number 2 ? ");
        num2 = int.Parse(Console.ReadLine());
    }
    public static int MaxOf2Numbers(int num1, int num2)
    {
        if (num1 > num2)
            return num1;
        else
            return num2;
    }
    public static void PrintResults(int Max)
    {
        Console.WriteLine($"The Maximum Number is: {Max}");
    }
}

