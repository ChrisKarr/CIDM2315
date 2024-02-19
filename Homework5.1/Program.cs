using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input the first number:");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the second number:");
        int B = Convert.ToInt32(Console.ReadLine());

        int num = LargestNumber(A, B);

        Console.WriteLine($"The largest number is {num}");

        static int LargestNumber(int x, int y)
        {
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
    }
}