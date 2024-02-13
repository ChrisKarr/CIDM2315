    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            int B = Convert.ToInt32(Console.ReadLine());
            int largest = LargestNumber(A, B);
            Console.WriteLine($"The largest number is {largest}");
        }
        static int LargestNumber(int A, int B)
        {
            if(A > B)
            {
                return A;
            }
            else
            {
                return B;
            }
        }
    }