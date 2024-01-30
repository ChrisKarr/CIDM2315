using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please input a year. I will tell you if it is a Leap Year or not.\nYear:");

        string inputYear = Console.ReadLine();

        int yearNumber = Convert.ToInt32(inputYear);

        if (yearNumber % 4 == 0 && yearNumber % 100 != 0)
        {
            Console.WriteLine($"The year {inputYear} is a Leap Year!");
        }
        else if (yearNumber % 400 == 0)
        {
            Console.WriteLine($"The year {inputYear} is a Leap Year!");
        }
        else
        {
            Console.WriteLine($"Sorry! The year {inputYear} is not a Leap Year.");
        }
    }
}