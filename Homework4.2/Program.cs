using System;
using System.Reflection.Metadata;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Now type (L) for left or (R) for right:");
        string facing = Console.ReadLine();
        Console.WriteLine($"Number = {num}, Shape = {facing}");

        if(facing == "L")
        {
            FacingLeft(num);
        }
        else if(facing == "R")
        {
            FacingRight(num);
        }
    }

    static void FacingLeft(int num)
    {
        for(int row = 0; row<num; row++)
        {
            for(int col = 0; col<=row; col++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }

    static void FacingRight(int num)
    {
        for(int row = 0; row<num; row++)
        {
            for(int col = 0; col<num; col++)
            {
                if(col<num - row - 1)
                Console.Write(' ');
                else
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
}