using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input the first number:");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the second number:");
        int B = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the third number:");
        int C = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Finally, input the fourth number:");
        int D = Convert.ToInt32(Console.ReadLine());
        

        Console.Write($"A = {A} | B = {B} | C = {C} | D = {D}\n");

        int max1 = LargestNumber(A, B);
        string max1name = A > B ? "A" : "B";
        Console.WriteLine($"The largest number between A and B is {max1}.");

        int max2 = LargestNumber(C, D);
        string max2name = C > D ? "C" : "D";
        Console.WriteLine($"The largest number between C and D is {max2}.");

        int max = LargestNumber(max1, max2);        
        Console.WriteLine($"The largest number between {max1name} and {max2name} is {max}");

        static int LargestNumber(int x, int y)
        {
            if(x > y)
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